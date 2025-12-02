namespace WP.Asaas.Sdk.Models.Common;

public class PixQrCodeResponse
{
    public string Id { get; set; }
    public string EncodedImage { get; init; }
    public string Payload { get; init; }
    public DateTime ExpirationDate { get; init; }
}