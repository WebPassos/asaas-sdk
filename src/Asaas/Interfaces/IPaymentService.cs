using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Payment.Requests;
using WP.Asaas.Sdk.Models.Payment.Responses;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentResponse> CreatePaymentAsync(CreatePaymentRequest request, CancellationToken cancellationToken);
        Task<CreditCardPaymentResponse> CreateCreditCardPaymentAsync(CreateCreditCardPaymentRequest request, CancellationToken cancellationToken);
        Task<PaymentListResponse> GetAllPaymentsAsync(CancellationToken cancellationToken);
        Task<PixQrCodeResponse> GetPaymentPixQrCodeByIdAsync(string paymentId, CancellationToken cancellationToken);
        Task<DeletePaymentResponse> DeletePaymentAsync(string paymentId, CancellationToken cancellationToken);
        Task<PaymentResponse> UpdatePaymentAsync(string paymentId, UpdatePaymentRequest request, CancellationToken cancellationToken);
        Task<PaymentResponse> RestorePaymentAsync(string paymentId, CancellationToken cancellationToken);
        Task<CaptureAuthorizedPaymentResponse> CaptureAuthorizedPaymentAsync(string paymentId, CancellationToken cancellationToken);
        Task<PayWithCreditCardResponse> PayWithCreditCardAsync(string paymentId, PayWithCreditCardRequest request, CancellationToken cancellationToken);
        Task<BillingInfoResponse> GetBillingInfoByIdAsync(string paymentId, CancellationToken cancellationToken);
        Task<ViewingInfoResponse> GetViewingInfoByIdAsync(string paymentId, CancellationToken cancellationToken);
        Task<IdentificationFieldResponse> GetIdentificationFieldAsync(string paymentId, CancellationToken cancellationToken);
        Task<PaymentResponse> ReceiveInCashAsync(string paymentId, ReceiveInCashRequest request, CancellationToken cancellationToken);
        Task<PaymentResponse> UndoReceivedInCashAsync(string paymentId, CancellationToken cancellationToken);
        Task<SimulatePaymentResponse> SimulatePaymentAsync(SimulatePaymentRequest request, CancellationToken cancellationToken);
        Task<PaymentLimitsResponse> GetPaymentLimitsAsync(CancellationToken cancellationToken);
    }
}
