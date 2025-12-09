namespace WP.Asaas.Sdk.Models.PaymentRefund.Requests;

public class ReverseChargeRequest
{
    public double Value { get; set; }
    public string Description { get; set; }
    public List<SplitRefundRequest> SplitRefunds { get; set; }
}