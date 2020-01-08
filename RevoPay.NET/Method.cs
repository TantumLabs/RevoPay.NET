using Newtonsoft.Json;

namespace RevoPay.NET
{
    /// <summary>
    /// This entry point allows access to information about the payment methods accepted in a PayPoint as well as information on high and low limits.
    /// </summary>
    public class Method
    {
        /// <summary>
        /// Array of Credential objects with the information to be used in onetime payments.
        /// </summary>
        [JsonProperty("credOneTime")]
        public CredentialObject CreditOneTime { get; set; }

        /// <summary>
        /// Array of Credential objects with the information to be used in scheduled payments.
        /// </summary>
        [JsonProperty("credRecurring")]
        public CredentialObject CreditRecurring { get; set; }

        /// <summary>
        /// Array of Velocity objects to be used for onetime payments.
        /// </summary>
        [JsonProperty("velocityOt")]
        public VelocityObject VelocityOneTime { get; set; }

        /// <summary>
        /// Array of Velocity objects to be used for scheduled payments.
        /// </summary>
        [JsonProperty("velocityRc")]
        public VelocityObject VelocityRecurring { get; set; }
    }
}
