using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Payment.Responses;

public class CaptureAuthorizedPaymentResponse : BasePaymentResponse
{
    public string Object { get; set; }
    public string Subscription { get; set; }
    public string Installment { get; set; }
    public string CheckoutSession { get; set; }
    public string PaymentLink { get; set; }
    public decimal NetValue { get; set; }
    public decimal? OriginalValue { get; set; }
    public decimal? InterestValue { get; set; }
    public string InvoiceUrl { get; set; }
    public string InvoiceNumber { get; set; }
    public string BankSlipUrl { get; set; }
    public bool PostalService { get; set; }
    public bool Anticipated { get; set; }
    public CreditCard CreditCard { get; set; }
    public bool CanBePaidAfterDueDate { get; set; }
    public string PixTransaction { get; set; }
    public string PixQrCodeId { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime OriginalDueDate { get; set; }
    public DateTime? PaymentDate { get; set; }
    public DateTime? ClientPaymentDate { get; set; }
    public int? InstallmentNumber { get; set; }
    public bool Anticipable { get; set; }
    public DateTime CreditDate { get; set; }
    public DateTime EstimatedCreditDate { get; set; }
    public string TransactionReceiptUrl { get; set; }
    public string NossoNumero { get; set; }
    public Chargeback Chargeback { get; set; }
    public Escrow Escrow { get; set; }
    public List<Refund> Refunds { get; set; }
}
