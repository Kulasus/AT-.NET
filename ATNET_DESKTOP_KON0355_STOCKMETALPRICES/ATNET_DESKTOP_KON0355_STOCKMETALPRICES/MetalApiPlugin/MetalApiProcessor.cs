using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedContext;
using RestSharp;
using Newtonsoft.Json.Linq;
using MetalApiPlugin.Properties;

namespace MetalApiPlugin
{
    class MetalApiProcessor : IPlugin
    {
        private RestClient restClient;
        private RestRequest restRequest;

        public MetalApiProcessor()
        {
            restClient = new RestClient(Resources.ApiUrl);
            restRequest = new RestRequest(Method.GET);
            restRequest.AddParameter("access_key", Resources.AccesKey);
            restRequest.AddParameter("base", Resources.Base);
            restRequest.AddParameter("symbols", Resources.Symbols);
        }

        public Dictionary<string,string> GetJsonString()
        {
            IRestResponse response = restClient.Execute(restRequest);

            Dictionary<string, string> result = new Dictionary<string, string>();
            var data = JObject.Parse(response.Content);

            result.Add("currency", Convert.ToString(data["base"]));
            result.Add("timestamp", Convert.ToString(data["timestamp"]));
            result.Add("price", Convert.ToString(data["rates"]["XAU"]));

            return result;
        }
    }
}
