using WP.Asaas.Sdk.Enums;

namespace WP.Asaas.Sdk.Models.PaymentDunning.Responses
{
    public class PaymentDunningResponse
    {
        public string Id { get; init; }
        public string DunningNumber { get; init; }
        public PaymentDunningStatus Status { get; init; }
        public PaymentDunningType Type { get; init; }
        public string Payment { get; init; }
        public DateTime RequestDate { get; init; }
        public string Description { get; init; }
        public decimal Value { get; init; }
        public decimal FeeValue { get; init; }
        public decimal NetValue { get; init; }
        public decimal ReceivedInCashFeeValue { get; init; }
        public string DenialReason { get; init; }
        public decimal CancellationFeeValue { get; init; }
        public bool IsNecessaryResendDocumentation { get; init; }
        public bool CanBeCancelled { get; init; }
    }
}