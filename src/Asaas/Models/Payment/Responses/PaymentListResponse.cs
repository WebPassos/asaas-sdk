namespace WP.Asaas.Sdk.Models.Payment.Responses
{
    public class PaymentListResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<PaymentResponse> Data { get; set; }
    }
}
