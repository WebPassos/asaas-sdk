namespace WP.Asaas.Sdk.Models.PaymentDunning.Responses
{
    public class SimulatedPaymentDunningResponse
    {
        public string Payment { get; init; }
        public decimal Value { get; init; }
        public List<PaymentDunningTypeSimulations> TypeSimulations { get; init; }
    }
}