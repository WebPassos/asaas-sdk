namespace AsaasSdk.Models.Finance;

public class FinancialTransaction
{
    public string Id { get; init; }
    public decimal Value { get; init; }
    public decimal Balance { get; init; }
    public string Type { get; init; }
    public DateTime Date { get; init; }
    public string Description { get; init; }
}