namespace WP.Asaas.Sdk.Models.PaymentPix.Requests;

public class PaymentPixQRCodeRequest
{
    public PaymentPixQRCodeQrCodeRequest QrCode { get; set; }
    public double? ChangeValue { get; set; }
    public double Value { get; set; }
    public string Description { get; set; }
    public DateTime? ScheduleDate { get; set; }
}

public class PaymentPixQRCodeQrCodeRequest
{
    public string Payload { get; set; }
}