namespace WP.Asaas.Sdk.Models.Payment.Responses
{
    public class PaymentLimitsDailyResponse
    {
        public int Limit { get; init; }
        public int Used { get; init; }
        public bool? WasReached { get; init; }
    }

    public class PaymentLimitsCreationResponse
    {
        public PaymentLimitsDailyResponse Daily { get; init; }
    }

    public class PaymentLimitsResponse
    {
        public PaymentLimitsCreationResponse Creation { get; init; }
    }
}
