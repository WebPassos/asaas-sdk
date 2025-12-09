namespace WP.Asaas.Sdk.Models.Transfer.Responses;

public class TransferListResponse
{
    public string Object { get; set; }
    public bool HasMore { get; set; }
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<TransferResponse> Data { get; set; }
}