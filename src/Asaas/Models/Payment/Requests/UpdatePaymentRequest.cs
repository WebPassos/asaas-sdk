using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Payment.Requests
{
    public class UpdatePaymentRequest
    {
        public string Customer { get; init; }
        public BillingType BillingType { get; init; }
        public decimal Value { get; init; }
        public string Description { get; init; }
        public Discount Discount { get; init; }
        public Interest Interest { get; init; }
        public Fine Fine { get; init; }
        public List<Split> Split { get; init; }
        public DateTime DueDate { get; init; }
        public bool? PostalService { get; init; }
    }
}