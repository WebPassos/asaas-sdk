using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.PaymentRefund.Responses;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Responses
{
    public class InstallmentPaymentResponse : BasePaymentResponse
    {
        public string Object { get; set; }
        public string Subscription { get; set; }
        public string Installment { get; set; }
        public string CheckoutSession { get; set; }
        public string PaymentLink { get; set; }
        public decimal NetValue { get; set; }
        public decimal? OriginalValue { get; set; }
        public decimal? InterestValue { get; set; }
        public CreditCardInfo CreditCard { get; set; }
        public bool CanBePaidAfterDueDate { get; set; }
        public string PixTransaction { get; set; }
        public string PixQrCodeId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime OriginalDueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? ClientPaymentDate { get; set; }
        public int? InstallmentNumber { get; set; }
        public string InvoiceUrl { get; set; }
        public string InvoiceNumber { get; set; }
        public bool Anticipated { get; set; }
        public bool Anticipable { get; set; }
        public DateTime CreditDate { get; set; }
        public DateTime EstimatedCreditDate { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public string NossoNumero { get; set; }
        public string BankSlipUrl { get; set; }
        public int? DaysAfterDueDateToRegistrationCancellation { get; set; }
        public ChargebackInfo Chargeback { get; set; }
        public EscrowInfo Escrow { get; set; }
        public List<RefundInfo> Refunds { get; set; }
    }
}
