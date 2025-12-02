using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.PaymentLink.Responses
{
    public class PaymentLinkResponse : BasePaymentResponse
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public string ChargeType { get; set; }
        public string Url { get; set; }
        public string SubscriptionCycle { get; set; }
        public string EndDate { get; set; }
        public int ViewCount { get; set; }
        public int MaxInstallmentCount { get; set; }
        public int? DueDateLimitDays { get; set; }
        public bool NotificationEnabled { get; set; }
        public bool IsAddressRequired { get; set; }
    }
}
