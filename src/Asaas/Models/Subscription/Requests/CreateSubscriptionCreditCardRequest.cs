using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.Subscription.Requests
{
    public class CreateSubscriptionCreditCardRequest
    {
        public string Customer { get; init; }
        public BillingType BillingType { get; init; }
        public decimal Value { get; init; }
        public string Description { get; init; }
        public Discount Discount { get; init; }
        public Interest Interest { get; init; }
        public Fine Fine { get; init; }
        public List<Split> Split { get; init; }
        public Cycle? Cycle { get; init; }
        public DateTime? EndDate { get; init; }
        public int? MaxPayments { get; init; }
        public DateTime NextDueDate { get; init; }
        public string ExternalReference { get; init; }
        public Callback Callback { get; init; }
        public CreditCardRequest CreditCard { get; init; }
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; init; }
        public string CreditCardToken { get; init; }
        public string RemoteIp { get; init; }
    }
}