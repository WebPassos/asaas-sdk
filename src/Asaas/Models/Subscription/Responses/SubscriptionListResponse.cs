namespace WP.Asaas.Sdk.Models.Subscription.Responses
{
    public class SubscriptionListResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<SubscriptionResponse> Data { get; set; }
    }
}