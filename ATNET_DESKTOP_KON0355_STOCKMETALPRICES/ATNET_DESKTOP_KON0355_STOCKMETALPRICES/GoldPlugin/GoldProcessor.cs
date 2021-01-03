using SharedContext;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using GoldPlugin.Properties;
using System;
using GoldPlugin.Exceptions;

namespace GoldPlugin
{
    public class GoldProcessor : IPlugin
    {
        private RestClient restClient { get; }
        private RestRequest restRequest;
        private static RestClient restClientStatus = new RestClient(Resources.ApiStatusUrl);
        private static List<string> supportedCurrencies = new List<string>(new string[]
        {
            Resources.EurMarking, Resources.CzkMarking, Resources.UsdMarking, Resources.GbpMarking
        });
        private static List<string> supportedMetals = new List<string>(new string[]
        {
            Resources.GoldMarking, Resources.SilverMarking, Resources.PalladiumMarking, Resources.PlatinumMarking
        });
        public GoldProcessor()
        {
            restClient = new RestClient(Resources.ApiUrl + Resources.GoldMarking + "/" + Resources.CzkMarking);
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("x-access-token", Resources.X_access_token);
            restRequest.AddHeader("Content-Type", Resources.Content_type);
        }
        public GoldProcessor(string metal, string currency)
        {
            if (!CheckMetal(metal.ToUpper()) || metal == null)
            {
                metal = Resources.GoldMarking;
            }
            if (!CheckCurrency(currency.ToUpper()) || currency == null)
            {
                currency = Resources.CzkMarking;
            }
            restClient = new RestClient(Resources.ApiUrl + metal + "/" + currency);
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("x-access-token", Resources.X_access_token);
            restRequest.AddHeader("Content-Type", Resources.Content_type);
        }

        private bool CheckMetal(string metal)
        {
            return supportedMetals.Contains(metal);
        }
        private bool CheckCurrency(string currency)
        {
            return supportedCurrencies.Contains(currency);
        }
        public Dictionary<string,string> GetJsonDataDict()
        {
            IRestResponse response = restClient.Execute(restRequest);
            if (response.IsSuccessful)
            {
                var data = JObject.Parse(response.Content);
                Dictionary<string, string> result = new Dictionary<string, string>();
                result.Add("currency", Convert.ToString(data["currency"]));
                result.Add("timestamp", Convert.ToString(data["timestamp"]));
                result.Add("price", Convert.ToString(data["price"]));
                return result;
            }
            else if (CheckApiStatus())
            {
                throw new ApiClientException(Resources.ApiClientInvalidRequestErrorMessage);
            }
            else
            {
                throw new ApiClientException(Resources.ApiClientResponseErrorMessage);
            }
        }
        private bool CheckApiStatus()
        {
            IRestResponse response = restClientStatus.Execute(restRequest);
            if (response.IsSuccessful)
            {
                var serviceStatusData = JObject.Parse(response.Content);
                var status = Convert.ToBoolean(serviceStatusData["result"]);
                return status;
            }
            else
            {
                throw new ApiClientException(Resources.ApiClientResponseErrorMessage);
            }
        }

    }
}
