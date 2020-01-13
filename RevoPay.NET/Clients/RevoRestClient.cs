using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevoPay.NET.Clients
{
    public class RevoRestClient : IRevoRestClient
    {
        public IRestClient RestClient { get; }

        public IRestRequest RestRequest { get; }

        private readonly string _token;
        private readonly string _companyID;
        private readonly bool _sandbox;
        private readonly string _endPoint;
        private readonly string productionUrl = "https://web2-vm.revopay.com/index.php";
        private readonly string sandboxUrl = "https://sandbox.revopay.com/master/index.php";

        public RevoRestClient(string CompanyID, string Token, bool Sandbox = false)
        {
            _companyID = CompanyID;
            _token = Token;
            _sandbox = Sandbox;
            _endPoint = productionUrl;
            if (_sandbox)
            {
                _endPoint = sandboxUrl;
            }
            RestClient = new RestClient(_endPoint);
            RestRequest = new RestRequest(RestSharp.Method.POST);
            RestRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            RestRequest.AddParameter("token", _token);
        }

        public async Task<T> SendRequest<T>(IRequest request)
        {
            RestRequest.Resource = request.EndPoint;
            Dictionary<string, dynamic> parameters = BuildRequestDictionary(request.PaypointID);
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            RestRequest.AddParameter("request", JsonConvert.SerializeObject(parameters, Formatting.None, settings));
            try
            {
                IRestResponse<T> response = await RestClient.ExecuteAsync<T>(RestRequest).ConfigureAwait(true);
                return response.Data;
            }
            catch (Exception ex)
            {
                throw new Exception("Revo Internal Server Error: " + ex.Message);
            }
        }

        private Dictionary<string, dynamic> BuildRequestDictionary(string PaypointID = null)
        {
            if (string.IsNullOrEmpty(PaypointID))
            {
                return new Dictionary<string, dynamic>
                {
                    { "scope", new { companyID = _companyID  } }
                };
            }
            return new Dictionary<string, dynamic>
            {
                { "scope", new { companyID = _companyID, paypointID = PaypointID  } }
            };
        }
    }
}
