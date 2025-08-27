namespace Asaas.Models.Common;

public class CreditCardRequest
{
    public string HolderName { get; init; }
    public string Number { get; init; }
    public string ExpiryMonth { get; init; }
    public string ExpiryYear { get; init; }
    public string Ccv { get; init; }
}