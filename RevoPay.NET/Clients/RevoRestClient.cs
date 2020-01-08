using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RevoPay.NET.Clients
{
    public class RevoRestClient : IRevoRestClient
    {
        public HttpClient HttpClient { get; }

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
            HttpClient = new HttpClient()
            {
                BaseAddress = new Uri(_endPoint)
            };
            HttpClient.DefaultRequestHeaders.Add("", "");
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
