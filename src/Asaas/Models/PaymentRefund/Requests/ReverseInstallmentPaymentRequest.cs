namespace WP.Asaas.Sdk.Models.PaymentRefund.Requests
{
    public class ReverseInstallmentPaymentRequest
    {
        public double Value { get; set; }
        public List<SplitRefundRequest> SplitRefunds { get; set; }
    }

    public class SplitRefundRequest
    {
        public string Id { get; set; }
        public double Value { get; set; }
    }
}
