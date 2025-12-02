namespace WP.Asaas.Sdk.Models.Payment.Requests;

public class ReceiveInCashRequest
{
    public DateTime PaymentDate { get; set; }
    public decimal Value { get; set; }
    public bool NotifyCustomer { get; set; }
}
