using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Subscription.Requests
{
    public class UpdateSubscriptionRequest
    {
        public string Customer { get; init; }
        public BillingType BillingType { get; init; }
        public decimal Value { get; init; }
        public string Description { get; init; }
        public Discount Discount { get; init; }
        public Interest Interest { get; init; }
        public Fine Fine { get; init; }
        public List<Split> Split { get; init; }
        public StatusType Status { get; init; }
        public DateTime? NextDueDate { get; init; }
        public Cycle? Cycle { get; init; }
        public DateTime? EndDate { get; init; }
        public bool? UpdatePendingPayments { get; init; }
        public string ExternalReference { get; init; }
        public Callback Callback { get; init; }
    }
}