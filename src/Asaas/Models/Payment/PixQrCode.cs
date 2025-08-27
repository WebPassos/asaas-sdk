namespace WP.Asaas.Sdk.Models.Payment;

public class PixQRCode
{
    public string EncodedImage { get; init; }
    public string Payload { get; init; }
    public DateTime ExpirationDate { get; init; }
}