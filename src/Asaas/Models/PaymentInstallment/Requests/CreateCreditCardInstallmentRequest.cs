using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Requests
{
    public class CreateCreditCardInstallmentRequest
    {
        public string Customer { get; set; }
        public BillingType BillingType { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public Interest Interest { get; set; }
        public Fine Fine { get; set; }
        public List<Split> Split { get; set; }
        public CreditCardRequest CreditCard { get; set; }
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }
        public DateTime DueDate { get; init; }
        public string CreditCardToken { get; set; }
        public bool? AuthorizeOnly { get; set; }
        public string RemoteIp { get; set; }
    }
}