using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PacUnionFinancial.Intergration.WebApi.Helpers
{
    public static class RoostifyRequestHelper
    {
        public static HttpClient ModifyClient(HttpClient client)
        {
           
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["RoostifyApiUrl"]);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", string.Format("Basic {0}", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["RoostifyApiToken"]))));
           
            return client;
        }
    }
}
