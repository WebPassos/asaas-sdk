namespace WP.Asaas.Sdk.Models.Common;

public class Escrow
{
    public string Id { get; set; }
    public string Status { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public DateTime? FinishDate { get; set; }
    public string FinishReason { get; set; }
}