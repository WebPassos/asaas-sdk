using WP.Asaas.Sdk.Models.Subscription.Requests;
using WP.Asaas.Sdk.Models.Subscription.Responses;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface ISubscriptionService
    {
        Task<SubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken);
        Task<SubscriptionListResponse> GetAllSubscriptionsAsync(CancellationToken cancellationToken);
        Task<SubscriptionResponse> CreateCreditCardSubscriptionAsync(CreateSubscriptionCreditCardRequest request, CancellationToken cancellationToken);
        Task<SubscriptionResponse> GetSubscriptionAsync(string id, CancellationToken cancellationToken);
        Task<DeletedSubscriptionResponse> DeleteSubscriptionAsync(string id, CancellationToken cancellationToken);
        Task<SubscriptionResponse> UpdateSubscriptionAsync(string id, UpdateSubscriptionRequest request, CancellationToken cancellationToken);
        Task<SubscriptionResponse> UpdateSubscriptionCreditCardAsync(string id, UpdateSubscriptionCreditCardRequest request, CancellationToken cancellationToken);
        Task<SubscriptionPaymentsListResponse> GetSubscriptionPaymentsAsync(string id, CancellationToken cancellationToken);
        Task<byte[]> GetSubscriptionPaymentBookAsync(string id, CancellationToken cancellationToken);
        Task<SubscriptionInvoiceSettingsResponse> CreateInvoiceSettingsAsync(string id, CreateInvoiceSettingsRequest request, CancellationToken cancellationToken);
        Task<SubscriptionInvoiceSettingsResponse> GetInvoiceSettingsAsync(string id, CancellationToken cancellationToken);
        Task<DeletedInvoiceSettingsResponse> DeleteInvoiceSettingsAsync(string id, CancellationToken cancellationToken);
        Task<SubscriptionInvoiceSettingsResponse> UpdateInvoiceSettingsAsync(string id, UpdateInvoiceSettingsRequest request, CancellationToken cancellationToken);
    }
}