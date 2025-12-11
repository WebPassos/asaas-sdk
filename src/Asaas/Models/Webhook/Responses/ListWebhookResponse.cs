namespace WP.Asaas.Sdk.Models.Webhook.Responses
{
    public class ListWebhookResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<WebhookResponse> Data { get; set; }
    }
}
