using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.PaymentLink.Responses
{
    public class PaymentLinkResponse
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Customer { get; set; }
        public double Value { get; set; }
        public Discount Discount { get; set; }
        public Interest Interest { get; set; }
        public Fine Fine { get; set; }
        public BillingType BillingType { get; set; }
        public PaymentStatus Status { get; set; }
        public string Description { get; set; }
        public string ExternalReference { get; set; }
        public bool Deleted { get; set; }
        public List<Split> Split { get; set; }
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