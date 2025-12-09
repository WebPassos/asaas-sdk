using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Responses
{
    public class PaymentInstallmentResponse
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
        public decimal PaymentValue { get; set; }
        public int InstallmentCount { get; set; }
        public int? ExpirationDay { get; set; }
        public string PaymentLink { get; set; }
        public string CheckoutSession { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public Chargeback Chargeback { get; set; }
        public List<Refund> Refunds { get; set; }
    }
}