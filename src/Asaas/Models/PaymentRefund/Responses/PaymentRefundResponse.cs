namespace WP.Asaas.Sdk.Models.PaymentRefund.Responses;

public class PaymentRefundResponse
{
    public string Object { get; set; }
    public string Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string Customer { get; set; }
    public string Subscription { get; set; }
    public string Installment { get; set; }
    public string CheckoutSession { get; set; }
    public string PaymentLink { get; set; }
    public decimal Value { get; set; }
    public decimal NetValue { get; set; }
    public decimal? OriginalValue { get; set; }
    public decimal? InterestValue { get; set; }
    public string Description { get; set; }
    public string BillingType { get; set; }
    public CreditCardInfo CreditCard { get; set; }
    public bool CanBePaidAfterDueDate { get; set; }
    public string PixTransaction { get; set; }
    public string PixQrCodeId { get; set; }
    public string Status { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime OriginalDueDate { get; set; }
    public DateTime? PaymentDate { get; set; }
    public DateTime? ClientPaymentDate { get; set; }
    public int? InstallmentNumber { get; set; }
    public string InvoiceUrl { get; set; }
    public string InvoiceNumber { get; set; }
    public string ExternalReference { get; set; }
    public bool Deleted { get; set; }
    public bool Anticipated { get; set; }
    public bool Anticipable { get; set; }
    public DateTime CreditDate { get; set; }
    public DateTime EstimatedCreditDate { get; set; }
    public string TransactionReceiptUrl { get; set; }
    public string NossoNumero { get; set; }
    public string BankSlipUrl { get; set; }
    public DiscountInfo Discount { get; set; }
    public FineInfo Fine { get; set; }
    public InterestInfo Interest { get; set; }
    public List<SplitInfo> Split { get; set; }
    public bool PostalService { get; set; }
    public int? DaysAfterDueDateToRegistrationCancellation { get; set; }
    public ChargebackInfo Chargeback { get; set; }
    public EscrowInfo Escrow { get; set; }
    public List<RefundInfo> Refunds { get; set; }
}

public class CreditCardInfo
{
    public string CreditCardNumber { get; set; }
    public string CreditCardBrand { get; set; }
    public string CreditCardToken { get; set; }
}

public class DiscountInfo
{
    public decimal Value { get; set; }
    public int DueDateLimitDays { get; set; }
    public string Type { get; set; }
}

public class FineInfo
{
    public decimal Value { get; set; }
}

public class InterestInfo
{
    public decimal Value { get; set; }
}

public class SplitInfo
{
    public string Id { get; set; }
    public string WalletId { get; set; }
    public decimal FixedValue { get; set; }
    public decimal? PercentualValue { get; set; }
    public decimal TotalValue { get; set; }
    public string CancellationReason { get; set; }
    public string Status { get; set; }
    public string ExternalReference { get; set; }
    public string Description { get; set; }
}

public class ChargebackInfo
{
    public string Id { get; set; }
    public string Payment { get; set; }
    public string Installment { get; set; }
    public string CustomerAccount { get; set; }
    public string Status { get; set; }
    public string Reason { get; set; }
    public DateTime DisputeStartDate { get; set; }
    public decimal Value { get; set; }
    public DateTime PaymentDate { get; set; }
    public ChargebackCreditCardInfo CreditCard { get; set; }
    public string DisputeStatus { get; set; }
    public DateTime DeadlineToSendDisputeDocuments { get; set; }
}

public class ChargebackCreditCardInfo
{
    public string Number { get; set; }
    public string Brand { get; set; }
}

public class EscrowInfo
{
    public string Id { get; set; }
    public string Status { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime FinishDate { get; set; }
    public string FinishReason { get; set; }
}

public class RefundInfo
{
    public DateTime DateCreated { get; set; }
    public string Status { get; set; }
    public decimal Value { get; set; }
    public string EndToEndIdentifier { get; set; }
    public string Description { get; set; }
    public DateTime EffectiveDate { get; set; }
    public string TransactionReceiptUrl { get; set; }
    public List<RefundedSplitInfo> RefundedSplits { get; set; }
}

public class RefundedSplitInfo
{
    public string Id { get; set; }
    public decimal Value { get; set; }
    public bool Done { get; set; }
}