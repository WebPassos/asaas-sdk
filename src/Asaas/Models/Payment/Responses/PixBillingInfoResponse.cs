namespace WP.Asaas.Sdk.Models.Payment.Responses;

public class PixBillingInfoResponse
{
    public string EncodedImage { get; init; }
    public string Payload { get; init; }
    public string ExpirationDate { get; init; }
    public string Description { get; init; }
}
