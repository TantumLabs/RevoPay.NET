using RevoPay.NET.Clients;
using System.Threading.Tasks;

namespace RevoPay.NET
{
    public static partial class Extensions
    {
        public async static Task<Method> GetPaymentMethodsAsync(this IRevoRestClient client, string PaypointID)
        {
            var request = new GetPaymentMethodRequest(PaypointID);

            return null;
        }
    }

    internal class GetPaymentMethodRequest : IRequest<Method>
    {
        public string EndPoint
        {
            get
            {
                return "/api2/open/methods";
            }
        }

        public string PaypointID { get; }

        public object RequestParameters { get; }

        public IResponse<Method> Response { get; set; }

        public GetPaymentMethodRequest(string PaypointID)
        {
            this.PaypointID = PaypointID;
        }
    }
}
