using WP.Asaas.Sdk.Models.PaymentLink.Requests;
using WP.Asaas.Sdk.Models.PaymentLink.Responses;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface IPaymentsLinkService
    {
        Task<PaymentLinkResponse> CreatePaymentLinkAsync(CreatePaymentLinkRequest request, CancellationToken cancellationToken);
        Task<PaymentLinkListResponse> GetAllPaymentLinksAsync(CancellationToken cancellationToken);
        Task<PaymentLinkResponse> UpdatePaymentLinkAsync(string paymentLinkId, UpdatePaymentLinkRequest request, CancellationToken cancellationToken);
        Task<PaymentLinkResponse> GetPaymentLinksAsync(string paymentLinkId, CancellationToken cancellationToken);
        Task<DeletedPaymentLinkResponse> DeletePaymentLinkAsync(string paymentLinkId, CancellationToken cancellationToken);
        Task<PaymentLinkResponse> RestorePaymentLinkAsync(string paymentLinkId, CancellationToken cancellationToken);
    }
}