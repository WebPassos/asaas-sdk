using WP.Asaas.Sdk.Models.Common.Enums;
using WP.Asaas.Sdk.Models.Payment.Enums;

namespace WP.Asaas.Sdk.Models.PaymentDunning;

public class PaymentDunningPaymentAvailable
{
    public string Payment { get; init; }
    public string Customer { get; init; }
    public decimal Value { get; init; }
    public PaymentStatus Status { get; init; }
    public BillingType BillingType { get; init; }
    public DateTime DueDate { get; init; }
    public PaymentDunningTypeSimulations TypeSimulations { get; init; }
}