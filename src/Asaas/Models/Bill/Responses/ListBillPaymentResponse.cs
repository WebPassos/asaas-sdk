namespace WP.Asaas.Sdk.Models.Bill.Responses
{
    public class ListBillPaymentResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<BillPaymentResponse> Data { get; set; }
    }
}
