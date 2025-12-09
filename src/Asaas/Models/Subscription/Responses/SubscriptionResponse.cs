using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Subscription.Responses
{
    public class SubscriptionResponse
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
        public string Object { get; set; }
        public string PaymentLink { get; set; }
        public Cycle Cycle { get; set; }
        public DateTime NextDueDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CheckoutSession { get; set; }
        public int? MaxPayments { get; set; }
    }
}