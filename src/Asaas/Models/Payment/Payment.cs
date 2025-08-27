using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Enums;
using WP.Asaas.Sdk.Models.Payment.Enums;

namespace WP.Asaas.Sdk.Models.Payment;

public class Payment
{
    public string Id { get; init; }
    public DateTime DateCreated { get; init; }
    public string Customer { get; init; }
    public string Subscription { get; init; }
    public string Installment { get; init; }
    public DateTime DueDate { get; init; }
    public decimal Value { get; init; }
    public decimal NetValue { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public BillingType BillingType { get; init; }
    public PaymentStatus Status { get; init; }
    public string Description { get; init; }
    public string ExternalReference { get; init; }
    public DateTime OriginalDueDate { get; init; }
    public decimal? OriginalValue { get; init; }
    public decimal? InterestValue { get; init; }
    public DateTime? ConfirmedDate { get; init; }
    public DateTime? PaymentDate { get; init; }
    public DateTime? ClientPaymentDate { get; init; }
    public string InvoiceUrl { get; init; }
    public string BankSlipUrl { get; init; }
    public string InvoiceNumber { get; init; }
    public bool Deleted { get; init; }
    public bool PostalService { get; init; }
    public bool Anticipated { get; init; }
    public CreditCard CreditCard { get; init; }
    public List<Split> Split { get; init; }
}