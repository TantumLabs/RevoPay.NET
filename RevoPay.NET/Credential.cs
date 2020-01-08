using Newtonsoft.Json;

namespace RevoPay.NET
{
    /// <summary>
    /// The credential object contains the data belonging to a payment credential to be used in the RevoPay platform.
    /// </summary>
    public class Credential
    {
        /// <summary>
        /// lowest amount allowed to be paid with this credential
        /// </summary>
        [JsonProperty("low_pay_range")]
        public decimal LowPayRange { get; set; }

        /// <summary>
        /// highest amount allowed to be paid with this credential
        /// </summary>
        [JsonProperty("high_pay_range")]
        public decimal HighPayRange { get; set; }

        /// <summary>
        /// Maximum total amount allowed in a transaction for this credential
        /// </summary>
        [JsonProperty("high_ticket")]
        public decimal HighTicket { get; set; }

        /// <summary>
        /// Fix convenience fee to be applied for the payments using this credential
        /// </summary>
        [JsonProperty("convenience_fee")]
        public decimal ConvenienceFee { get; set; }

        /// <summary>
        /// Percentage to be applied to the main amount for convenience fee calculation
        /// </summary>
        [JsonProperty("convenience_fee_float")]
        public decimal ConvenienceFeeFloat { get; set; }

        /// <summary>
        /// Fix convenience fee to be applied for the dynamic AutoPayments using this credential
        /// </summary>
        [JsonProperty("convenience_fee_drp")]
        public decimal ConvenienceFeeDRP { get; set; }

        /// <summary>
        /// Percentage to be applied to the main amount for convenience fee calculation (only applied to dynamic AutoPayments)
        /// </summary>
        [JsonProperty("convenience_fee_float_drp")]
        public decimal ConvenienceFeeFloatDRP { get; set; }
    }
}
