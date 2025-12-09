using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.PaymentDunning
{
    public class PaymentDunningTypeSimulations
    {
        public PaymentDunningType Type { get; init; }
        public bool IsAllowed { get; init; }
        public string NotAllowedReason { get; init; }
        public double FeeValue  { get; init; }
        public double NetValue { get; init; }

    }
}