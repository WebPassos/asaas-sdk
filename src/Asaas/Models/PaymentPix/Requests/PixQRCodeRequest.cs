using WP.Asaas.Sdk.Models.PaymentPix.Enums;

namespace WP.Asaas.Sdk.Models.PaymentPix.Requests;

public class PixQRCodeRequest
{
    public string addressKey { get; set; }
    public string description { get; set; }
    public double value { get; set; }
    public FormatType formatType { get; set; }
    public DateTime expirationDate { get; set; }
    public bool allowsMultiplePayments { get; set; }
}