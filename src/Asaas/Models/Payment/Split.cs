namespace Asaas.Models.Payment;

public class Split
{
    public string WalletId { get; init; }
    public decimal FixedValue { get; init; }
    public decimal PercentualValue { get; init; }
}