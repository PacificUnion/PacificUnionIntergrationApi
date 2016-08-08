using PacUnionFinancial.Intergration.WebApi.Helpers;
using PacUnionFinancial.Intergration.WebApi.Models;
using PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PacUnionFinancial.Intergration.WebApi.Controllers
{
    [RoutePrefix("api/RoostifyWebHook")]
    public class RoostifyWebHookController : ApiController
    {

        // POST api/RoostifyWebHook
        public async Task Post([FromBody]RoostifyNotification notification)
        {
            var roostifySignature = Request.Headers.FirstOrDefault(h => h.Key == "X-Roostify-Signature");
            LoanApplication loanApplication = null;
            try
            {
                if (roostifySignature.Value != null)
                {
                    if (!string.IsNullOrEmpty(notification.id))
                    {
                        switch (notification.event_type)
                        {
                            default:
                            case "application.created":
                                using (var client = new HttpClient())
                                {
                                    using (var integrationService = new LeadIntegrationServiceClient())
                                    {
                                        RoostifyRequestHelper.ModifyClient(client);
                                        

                                        //got a valid loan application check to see if we have recorded if
                                        loanApplication = await GetLoanById(notification.id);
                                        if (loanApplication == null)
                                        {
                                            loanApplication = new LoanApplication
                                            {
                                                ApplicationIdentifier = notification.id,
                                                DateReceived = DateTime.UtcNow,
                                                RetrievalAttempts = 0,
                                                AppRetrievalError = false

                                            };
                                            loanApplication = await SaveLoanApplication(loanApplication);
                                        }

                                        await CreateInfoAppLog("Calling Roostify API", loanApplication.LoanApplicationID);

                                        if (loanApplication.RetrievalAttempts > 3)
                                            return;
                                        //HttpResponseMessage response = await client.GetAsync(string.Format("loan_applications/{0}/mismo?username=8341903819591029", notification.id));
                                        HttpResponseMessage response = await client.GetAsync(string.Format("loan_applications/{0}/fnm?account_id={1}&access_token={2}", notification.id, ConfigurationManager.AppSettings["RoostifyAccountID"], ConfigurationManager.AppSettings["RoostifyApiToken"]));


                                        if (response.IsSuccessStatusCode)
                                        {
                                            loanApplication.AppRetrievalError = false;
                                            await SaveLoanApplication(loanApplication);

                                            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                                            string applicationData = await response.Content.ReadAsStringAsync();

                                            byte[] data = Convert.FromBase64String(applicationData);
                                            string decodedString = Encoding.UTF8.GetString(data);

                                            await CreateInfoAppLog(decodedString, loanApplication.LoanApplicationID);
                                            //post application to Open Close
                                            using (var ocClient = new com.loanpacific.oc.HubServices())
                                            {

                                                //Create Web services request 
                                                var strXML = "<NewDataSet><Parameters>";
                                                strXML = strXML + "<LoginName>" + ConfigurationManager.AppSettings["OcLoginName"] + "</LoginName>";
                                                strXML = strXML + "<Source>Roostify</Source>";
                                                strXML = strXML + "<Comments>Roostify Application Created Event</Comments>";
                                                strXML = strXML + "<FNMA><![CDATA[" + decodedString + "]]></FNMA>";
                                                strXML = strXML + "</Parameters></NewDataSet>";

                                                if (loanApplication.LosPostAttempts > 3)
                                                    return;
                                                loanApplication.LosPostAttempts++;
                                                await SaveLoanApplication(loanApplication);

                                                var result = ocClient.TransactionString("xact_brokerloanimport", false, strXML, 1, ConfigurationManager.AppSettings["OcUsername"], ConfigurationManager.AppSettings["OcPassword"]);
                                                if (result != null)
                                                {
                                                    if (result.Tables["Result"].Rows.Count > 0)
                                                    {
                                                        var success = (bool)result.Tables["Result"].Rows[0][0];
                                                        if (success)
                                                        {
                                                            loanApplication.PostToLosSuccessful = true;
                                                            loanApplication.DatePosted = DateTime.UtcNow;
                                                            await SaveLoanApplication(loanApplication);
                                                        }
                                                        else
                                                        {
                                                            var error = (string)result.Tables["Result"].Rows[0][1];
                                                            loanApplication.PostToLosSuccessful = false;
                                                            
                                                            await SaveLoanApplication(loanApplication);
                                                            await CreateApplicationErrorAppLog(error,loanApplication.LoanApplicationID)
                                                        }
                                                    }

                                                }

                                            }
                                        }else
                                        {
                                            loanApplication.RetrievalAttempts++;
                                            loanApplication.AppRetrievalError = true;
                                            await SaveLoanApplication(loanApplication);
                                        }
                                    }

                                }
                                break;
                        }
                    }
                }
            }catch(Exception exc)
            {
               
                long? id ;
                if (loanApplication == null)
                {
                    id = null;
                }
                else
                {
                    id = loanApplication.LoanApplicationID;
                }
                await CreateExcAppLog(exc, id);
            }

        }

        private async Task<LoanApplication> GetLoanById(string loanID)
        {
            using (var integrationService = new LeadIntegrationServiceClient())
            {
                return await integrationService.GetLoanApplicationByAppIdentifierAsync(loanID);
            }
        }
        private async Task<LoanApplication> SaveLoanApplication(LoanApplication loanApplication)
        {
            using (var integrationService = new LeadIntegrationServiceClient())
            {
                return await integrationService.SaveLoanApplicationAsync(loanApplication);
            }
        }
        private async Task CreateInfoAppLog(string message, long loanApplicationID)
        {
            
            AppLog log = new AppLog
            {
                DateCreated = DateTime.UtcNow,
                IsError = false,
                LoanApplicationID = loanApplicationID,
                LogText = message
            };
            using (var integrationService = new LeadIntegrationServiceClient())
            {
                await integrationService.SaveAppLogAsync(log);
            }
        }

        private async Task CreateExcAppLog(Exception exc, long? loanApplicationID)
        {

            AppLog log = new AppLog
            {
                DateCreated = DateTime.UtcNow,
                IsError = true,
                LoanApplicationID = loanApplicationID,
                LogText = exc.GetBaseException().Message,
                StackTrace = exc.StackTrace
            };
            using (var integrationService = new LeadIntegrationServiceClient())
            {
                await integrationService.SaveAppLogAsync(log);
            }
        }


        private async Task CreateApplicationErrorAppLog(string error, long loanApplicationID)
        {
            
            AppLog log = new AppLog
            {
                DateCreated = DateTime.UtcNow,
                IsError = true,
                LoanApplicationID = loanApplicationID,
                LogText = error
            };
            using (var integrationService = new LeadIntegrationServiceClient())
            {
                await integrationService.SaveAppLogAsync(log);
            }
        }

    }

    
}
