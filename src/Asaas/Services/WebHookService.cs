using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Webhook.Requests;
using WP.Asaas.Sdk.Models.Webhook.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class WebHookService : IWebHookService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;

        public WebHookService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<WebhookResponse> CreateWebhookAsync(WebhookRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<WebhookResponse>($"/{Version}/webhooks", request, cancellationToken);
            return result;
        }

        public async Task<ListWebhookResponse> GetAllWebhooksAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListWebhookResponse>($"/{Version}/webhooks", cancellationToken);
            return result;
        }

        public async Task<WebhookResponse> GetWebhookByIdAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<WebhookResponse>($"/{Version}/webhooks/{id}", cancellationToken);
            return result;
        }

        public async Task<WebhookResponse> UpdateWebhookAsync(string id, WebhookRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PutAsync<WebhookResponse>($"/{Version}/webhooks/{id}", request, cancellationToken);
            return result;
        }

        public async Task<DeleteWebhookResponse> DeleteWebhookAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.DeleteAsync<DeleteWebhookResponse>($"/{Version}/webhooks/{id}", cancellationToken);
            return result;
        }
    }
}
