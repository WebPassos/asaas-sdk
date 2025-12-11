namespace WP.Asaas.Sdk.Models.Payment.Requests
{
    public class SimulatePaymentRequest
    {
        public decimal Value { get; set; }
        public int InstallmentCount { get; set; }
        public List<string> BillingTypes { get; set; }
    }
}
