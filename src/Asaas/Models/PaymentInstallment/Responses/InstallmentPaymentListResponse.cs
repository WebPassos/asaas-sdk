namespace WP.Asaas.Sdk.Models.PaymentInstallment.Responses
{
    public class InstallmentPaymentListResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<InstallmentPaymentResponse> Data { get; set; }
    }
}
