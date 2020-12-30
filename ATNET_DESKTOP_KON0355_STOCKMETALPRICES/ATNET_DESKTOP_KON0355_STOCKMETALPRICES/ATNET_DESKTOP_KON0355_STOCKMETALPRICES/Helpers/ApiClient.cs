using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Properties;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Exceptions;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers
{
    class ApiClient
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
        public ApiClient(string metal, string currency)
        {
            if (!CheckMetal(metal.ToUpper()))
            {
                throw new ApiClientException(Resources.ApiClientMetalErrorMessage + metal);
            }
            if (!CheckCurrency(currency.ToUpper()))
            {
                throw new ApiClientException(Resources.ApiClientCurrencyErrorMessage + currency);
            }
            restClient = new RestClient(Resources.ApiUrl + metal + "/" + currency);
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("x-access-token", Resources.X_access_token);
            restRequest.AddHeader("Content-Type", Resources.Content_type);
        }

        public string GetJsonString()
        {
            IRestResponse response = restClient.Execute(restRequest);
            if(response.IsSuccessful)
            {
                return response.Content;
            }
            else if(CheckApiStatus())
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
            else {
                throw new ApiClientException(Resources.ApiClientResponseErrorMessage);
            }
        }

        private bool CheckMetal(string metal)
        {
            return supportedMetals.Contains(metal);
        }

        private bool CheckCurrency(string currency)
        {
            return supportedCurrencies.Contains(currency);
        }

     }
}
