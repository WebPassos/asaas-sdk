using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.Payment.Responses
{
    public class PayWithCreditCardResponse
    {
        public string Id { get; init; }
        public DateTime DateCreated { get; init; }
        public string Customer { get; init; }
        public double Value { get; init; }
        public Discount Discount { get; init; }
        public Interest Interest { get; init; }
        public Fine Fine { get; init; }
        public BillingType BillingType { get; init; }
        public PaymentStatus Status { get; init; }
        public string Description { get; init; }
        public string ExternalReference { get; init; }
        public bool Deleted { get; init; }
        public List<Split> Split { get; init; }
    }
}
