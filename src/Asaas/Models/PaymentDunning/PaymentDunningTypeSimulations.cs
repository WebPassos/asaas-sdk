using WP.Asaas.Sdk.Models.PaymentDunning.Enums;

namespace WP.Asaas.Sdk.Models.PaymentDunning;

public class PaymentDunningTypeSimulations
{
    public PaymentDunningType Type { get; init; }
    public bool IsAllowed { get; init; }
    public string NotAllowedReason { get; init; }
    public DateTime? StartDate { get; init; }
    public decimal FeeValue { get; init; }
    public decimal NetValue { get; init; }
}