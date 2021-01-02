using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedContext;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace MetalApiPlugin
{
    class MetalApiProcessor : IPlugin
    {
        public Dictionary<string,string> GetJsonString()
        {
            RestClient restClient = new RestClient("https://metals-api.com/api/latest");
            RestRequest restRequest = new RestRequest(Method.GET);
            restRequest.AddParameter("access_key", "xdrt8gv2b6ho8r9pj4tcnyag8qhy4z65y50d03710664x27hjoixb47ijfbw");
            restRequest.AddParameter("base", "CZK");
            restRequest.AddParameter("symbols", "XAU");
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
