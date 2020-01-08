using Newtonsoft.Json;
using System.Collections.Generic;

namespace RevoPay.NET
{
    /// <summary>
    /// array of credential objects for each pay type
    /// </summary>
    public class CredentialObject
    {
        /// <summary>
        /// e-check credential object
        /// </summary>
        [JsonProperty("ec")]
        public List<Credential> ECheck { get; set; }

        /// <summary>
        /// credit card credential object
        /// </summary>
        [JsonProperty("cc")]
        public List<Credential> CreditCard { get; set; }

        /// <summary>
        /// AMEX credit card credential object
        /// </summary>
        [JsonProperty("amex")]
        public List<Credential> AMEX { get; set; }
    }
}
