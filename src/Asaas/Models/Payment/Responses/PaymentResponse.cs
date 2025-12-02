using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.Payment.Responses;

public class PaymentResponse : BasePaymentResponse
{
    public string Subscription { get; init; }
    public string Installment { get; init; }
    public DateTime DueDate { get; init; }
    public decimal NetValue { get; init; }
    public DateTime OriginalDueDate { get; init; }
    public decimal? OriginalValue { get; init; }
    public decimal? InterestValue { get; init; }
    public DateTime? ConfirmedDate { get; init; }
    public DateTime? PaymentDate { get; init; }
    public DateTime? ClientPaymentDate { get; init; }
    public string InvoiceUrl { get; init; }
    public string BankSlipUrl { get; init; }
    public string InvoiceNumber { get; init; }
    public bool PostalService { get; init; }
    public bool Anticipated { get; init; }
    public CreditCard CreditCard { get; init; }
}
