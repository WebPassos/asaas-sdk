using WP.Asaas.Sdk.Models.Common.Enums;

namespace WP.Asaas.Sdk.Models.Installment;

public class Installment
{
    public string Id { get; init; }
    public decimal Value { get; init; }
    public decimal PaymentValue { get; init; }
    public int InstallmentCount { get; init; }
    public BillingType BillingType { get; init; }
    public DateTime? PaymentDate { get; init; }
    public string Description { get; init; }
    public DateTime ExpirationDay { get; init; }
    public string Customer { get; init; }
    public bool Deleted { get; init; }
}