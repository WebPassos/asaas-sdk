namespace WP.Asaas.Sdk.Models.Invoice.Responses;

public class ListInvoiceResponse
{
    public string Object { get; set; }
    public bool HasMore { get; set; }
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<InvoiceResponse> Data { get; set; }
}
