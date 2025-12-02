namespace WP.Asaas.Sdk.Models.Finance.Responses;

public class FinancialTransactionResponse
{
    public string Id { get; init; }
    public double Value { get; init; }
    public double Balance { get; init; }
    public string Type { get; init; }
    public DateTime Date { get; init; }
    public string Description { get; init; }
}