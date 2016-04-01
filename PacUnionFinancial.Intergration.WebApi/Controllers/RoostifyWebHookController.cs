using PacUnionFinancial.Intergration.WebApi.Helpers;
using PacUnionFinancial.Intergration.WebApi.Models;
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

                                RoostifyRequestHelper.ModifyClient(client);

                                //HttpResponseMessage response = await client.GetAsync(string.Format("loan_applications/{0}/mismo?username=8341903819591029", notification.id));
                                HttpResponseMessage response = await client.GetAsync(string.Format("loan_applications/{0}/fnm?account_id={1}&access_token={2}", notification.id,ConfigurationManager.AppSettings["RoostifyAccountID"], ConfigurationManager.AppSettings["RoostifyApiToken"]));

                                
                                if (response.IsSuccessStatusCode)
                                {
                                    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                                    string applicationData = await response.Content.ReadAsStringAsync();
                    
                                    byte[] data = Convert.FromBase64String(applicationData);
                                    string decodedString = Encoding.UTF8.GetString(data);

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
                                       
                                        var result = ocClient.TransactionString("xact_brokerloanimport", false, strXML, 1, ConfigurationManager.AppSettings["OcUsername"], ConfigurationManager.AppSettings["OcPassword"]);
                                        if (result != null)
                                        {
                                            if(result.Tables["Result"].Rows.Count > 0)
                                            {
                                                var success = (bool)result.Tables["Result"].Rows[0][0];
                                                if (success)
                                                {

                                                }
                                                else
                                                {
                                                    var error = (string)result.Tables["Result"].Rows[0][1];
                                                }
                                            }

                                        }

                                    }
                                }

                            }
                            break;
                    }
                }
            }

        }

    }
}
