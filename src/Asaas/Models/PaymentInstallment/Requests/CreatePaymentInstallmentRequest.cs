using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Requests
{
    public class CreatePaymentInstallmentRequest
    {
        public string Customer { get; set; }
        public BillingType BillingType { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public Interest Interest { get; set; }
        public Fine Fine { get; set; }
        public List<Split> Split { get; set; }
        public int InstallmentCount { get; set; }
        public decimal? TotalValue { get; set; }
        public int? ExpirationDay { get; set; }
        public string PaymentExternalReference { get; set; }
    }
}