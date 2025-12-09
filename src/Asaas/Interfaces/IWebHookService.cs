using WP.Asaas.Sdk.Models.Webhook.Requests;
using WP.Asaas.Sdk.Models.Webhook.Responses;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface IWebHookService
    {
        Task<WebhookResponse> CreateWebhookAsync(WebhookRequest request, CancellationToken cancellationToken);
        Task<ListWebhookResponse> GetAllWebhooksAsync(CancellationToken cancellationToken);
        Task<WebhookResponse> GetWebhookByIdAsync(string id, CancellationToken cancellationToken);
        Task<WebhookResponse> UpdateWebhookAsync(string id, WebhookRequest request, CancellationToken cancellationToken);
        Task<DeleteWebhookResponse> DeleteWebhookAsync(string id, CancellationToken cancellationToken);
    }
}