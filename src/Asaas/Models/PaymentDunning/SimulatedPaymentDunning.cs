namespace Asaas.Models.PaymentDunning;

public class SimulatedPaymentDunning
{
    public string Payment { get; init; }
    public decimal Value { get; init; }
    public PaymentDunningTypeSimulations TypeSimulations { get; init; }
}