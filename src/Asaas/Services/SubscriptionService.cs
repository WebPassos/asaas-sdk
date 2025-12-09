using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Subscription.Requests;
using WP.Asaas.Sdk.Models.Subscription.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;
        public SubscriptionService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<SubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<SubscriptionResponse>($"{Version}/subscriptions", request, cancellationToken);
            return result;
        }

        public async Task<SubscriptionListResponse> GetAllSubscriptionsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<SubscriptionListResponse>($"{Version}/subscriptions", cancellationToken);
            return result;
        }

        public async Task<SubscriptionResponse> CreateCreditCardSubscriptionAsync(CreateSubscriptionCreditCardRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<SubscriptionResponse>($"{Version}/subscriptions", request, cancellationToken);
            return result;
        }

        public async Task<SubscriptionResponse> GetSubscriptionAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<SubscriptionResponse>($"{Version}/subscriptions/{id}", cancellationToken);
            return result;
        }

        public async Task<DeletedSubscriptionResponse> DeleteSubscriptionAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.DeleteAsync<DeletedSubscriptionResponse>($"{Version}/subscriptions/{id}", cancellationToken);
            return result;
        }

        public async Task<SubscriptionResponse> UpdateSubscriptionAsync(string id, UpdateSubscriptionRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PutAsync<SubscriptionResponse>($"{Version}/subscriptions/{id}", request, cancellationToken);
            return result;
        }

        public async Task<SubscriptionResponse> UpdateSubscriptionCreditCardAsync(string id, UpdateSubscriptionCreditCardRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PutAsync<SubscriptionResponse>($"{Version}/subscriptions/{id}/creditCard", request, cancellationToken);
            return result;
        }

        public async Task<SubscriptionPaymentsListResponse> GetSubscriptionPaymentsAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<SubscriptionPaymentsListResponse>($"{Version}/subscriptions/{id}/payments", cancellationToken);
            return result;
        }

        public async Task<byte[]> GetSubscriptionPaymentBookAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<byte[]>($"{Version}/subscriptions/{id}/paymentBook", cancellationToken);
            return result;
        }

        public async Task<SubscriptionInvoiceSettingsResponse> CreateInvoiceSettingsAsync(string id, CreateInvoiceSettingsRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<SubscriptionInvoiceSettingsResponse>($"{Version}/subscriptions/{id}/invoiceSettings", request, cancellationToken);
            return result;
        }

        public async Task<SubscriptionInvoiceSettingsResponse> GetInvoiceSettingsAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<SubscriptionInvoiceSettingsResponse>($"{Version}/subscriptions/{id}/invoiceSettings", cancellationToken);
            return result;
        }

        public async Task<DeletedInvoiceSettingsResponse> DeleteInvoiceSettingsAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.DeleteAsync<DeletedInvoiceSettingsResponse>($"{Version}/subscriptions/{id}/invoiceSettings", cancellationToken);
            return result;
        }

        public async Task<SubscriptionInvoiceSettingsResponse> UpdateInvoiceSettingsAsync(string id, UpdateInvoiceSettingsRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PutAsync<SubscriptionInvoiceSettingsResponse>($"{Version}/subscriptions/{id}/invoiceSettings", request, cancellationToken);
            return result;
        }

        public async Task<SubscriptionInvoiceListResponse> GetSubscriptionInvoicesAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<SubscriptionInvoiceListResponse>($"{Version}/subscriptions/{id}/invoices", cancellationToken);
            return result;
        }
    }
}