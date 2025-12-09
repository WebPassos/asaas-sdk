namespace WP.Asaas.Sdk.Models.PaymentLink.Responses;

public class PaymentLinkListResponse
{
    public string Object { get; set; }
    public bool HasMore { get; set; }
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<PaymentLinkResponse> Data { get; set; }
}