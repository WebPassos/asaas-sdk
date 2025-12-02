namespace WP.Asaas.Sdk.Models.PaymentDunning.Responses;

public class ListPaymentDunningPartialPaymentResponse
{
    public string Object { get; set; }
    public bool HasMore { get; set; }
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<PaymentDunningPartialPaymentResponse> Data { get; set; }
}
