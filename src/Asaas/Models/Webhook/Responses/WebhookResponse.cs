namespace WP.Asaas.Sdk.Models.Webhook.Responses;

public class WebhookResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Email { get; set; }
    public bool Enabled { get; set; }
    public bool Interrupted { get; set; }
    public int ApiVersion { get; set; }
    public bool HasAuthToken { get; set; }
    public string SendType { get; set; }
    public List<string> Events { get; set; }
}
