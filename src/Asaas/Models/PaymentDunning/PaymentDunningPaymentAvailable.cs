using Asaas.Models.Common.Enums;
using Asaas.Models.Payment.Enums;

namespace Asaas.Models.PaymentDunning;

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