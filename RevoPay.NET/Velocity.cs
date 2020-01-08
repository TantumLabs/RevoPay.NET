using Newtonsoft.Json;

namespace RevoPay.NET
{
    /// <summary>
    /// The velocity object contains the limits in the RevoPay platform for each payment type allowed to the PayPoint.
    /// </summary>
    public class Velocity
    {
        /// <summary>
        /// lowest amount allowed to pay with this payment type
        /// </summary>
        [JsonProperty("low_pay_range")]
        public decimal LowPayRange { get; set; }

        /// <summary>
        /// highest amount allowed to pay with this payment type
        /// </summary>
        [JsonProperty("high_pay_range")]
        public decimal HighPayRange { get; set; }
    }
}
