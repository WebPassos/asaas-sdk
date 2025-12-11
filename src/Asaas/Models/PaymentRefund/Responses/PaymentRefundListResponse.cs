using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.PaymentRefund.Responses
{
    public class PaymentRefundListResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<Refund> Data { get; set; }
    }
}