using RevoPay.NET.Clients;

namespace RevoPay.NET
{
    public static partial class Extensions
    {
        public async static void GetPaymentMethodsAsync(this IRevoRestClient client, string PaypointID)
        {
            
        }
    }

    public class GetPaymentMethods : IRequest
    {
        public string EndPoint
        {
            get
            {
                return "/api2/open/methods";
            }
        }
    }
}
