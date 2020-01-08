using Newtonsoft.Json;

namespace RevoPay.NET
{
    public class VelocityObject
    {
        /// <summary>
        /// e-check velocity object
        /// </summary>
        [JsonProperty("ec")]
        public Velocity ECheck { get; set; }

        /// <summary>
        /// credit card velocity object
        /// </summary>
        [JsonProperty("cc")]
        public Velocity CreditCard { get; set; }

        /// <summary>
        /// AMEX Velocity object
        /// </summary>
        [JsonProperty("amex")]
        public Velocity Amex { get; set; }
    }
}
