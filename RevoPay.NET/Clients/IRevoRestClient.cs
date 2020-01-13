using RestSharp;
using System.Threading.Tasks;

namespace RevoPay.NET.Clients
{
    public interface IRevoRestClient
    {
        ///// <summary>
        ///// Get the http client that makes requests
        ///// </summary>
        //HttpClient HttpClient { get; }

        IRestClient RestClient { get; }

        IRestRequest RestRequest { get; }

        ///// <summary>
        ///// Make a request to Revo
        ///// </summary>
        /////
        ///// <param name="request">Request to make</param>
        ///// <returns>response of the request</returns>
        //Response Request(Request request);

        Task<T> SendRequest<T>();
    }
}
