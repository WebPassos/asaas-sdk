using Asaas.Models.PaymentDunning.Enums;

namespace Asaas.Models.PaymentDunning;

public class PaymentDunningTypeSimulations
{
    public PaymentDunningType Type { get; init; }
    public bool IsAllowed { get; init; }
    public string NotAllowedReason { get; init; }
    public DateTime? StartDate { get; init; }
    public decimal FeeValue { get; init; }
    public decimal NetValue { get; init; }
}