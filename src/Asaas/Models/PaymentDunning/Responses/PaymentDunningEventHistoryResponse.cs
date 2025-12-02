namespace WP.Asaas.Sdk.Models.PaymentDunning.Responses;

public class PaymentDunningEventHistoryResponse
{
    public string Status { get; init; }
    public string Description { get; init; }
    public DateTime EventDate { get; init; }
}

public class ListPaymentDunningEventHistoryResponse
{
    public string Object { get; set; }
    public bool HasMore { get; set; }
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<PaymentDunningEventHistoryResponse> Data { get; set; }
}