using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.PaymentRefund.Responses;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Responses
{
    public class PaymentInstallmentResponse : BasePaymentResponse
    {
        public string Object { get; set; }
        public decimal PaymentValue { get; set; }
        public int InstallmentCount { get; set; }
        public int? ExpirationDay { get; set; }
        public string PaymentLink { get; set; }
        public string CheckoutSession { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public ChargebackInfo Chargeback { get; set; }
        public List<RefundInfo> Refunds { get; set; }
    }
}
