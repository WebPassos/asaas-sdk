using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Payment.Requests;
using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Payment.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class PaymentService : IPaymentService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;
        public PaymentService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<PaymentResponse> CreatePaymentAsync(CreatePaymentRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentResponse>($"/{Version}/payments", request, cancellationToken);
            return result;
        }

        public async Task<CreditCardPaymentResponse> CreateCreditCardPaymentAsync(CreateCreditCardPaymentRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<CreditCardPaymentResponse>($"/{Version}/payments", request, cancellationToken);
            return result;
        }

        public async Task<PaymentListResponse> GetAllPaymentsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<PaymentListResponse>($"/{Version}/payments", cancellationToken);
            return result;
        }

        public async Task<PixQrCodeResponse> GetPaymentPixQrCodeByIdAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<PixQrCodeResponse>($"/{Version}/payments/{paymentId}/pixQrCode", cancellationToken);
            return result;
        }

        public async Task<DeletePaymentResponse> DeletePaymentAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.DeleteAsync<DeletePaymentResponse>($"/{Version}/payments/{paymentId}", cancellationToken);
            return result;
        }

        public async Task<PaymentResponse> UpdatePaymentAsync(string paymentId, UpdatePaymentRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PutAsync<PaymentResponse>($"/{Version}/payments/{paymentId}", request, cancellationToken);
            return result;
        }

        public async Task<PaymentResponse> RestorePaymentAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentResponse>($"/{Version}/payments/{paymentId}/restore", null, cancellationToken);
            return result;
        }

        public async Task<CaptureAuthorizedPaymentResponse> CaptureAuthorizedPaymentAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<CaptureAuthorizedPaymentResponse>($"/{Version}/payments/{paymentId}/captureAuthorizedPayment", null, cancellationToken);
            return result;
        }

        public async Task<PayWithCreditCardResponse> PayWithCreditCardAsync(string paymentId, PayWithCreditCardRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PayWithCreditCardResponse>($"/{Version}/payments/{paymentId}/payWithCreditCard", request, cancellationToken);
            return result;
        }

        public async Task<BillingInfoResponse> GetBillingInfoByIdAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<BillingInfoResponse>($"/{Version}/payments/{paymentId}/billingInfo", cancellationToken);
            return result;
        }

        public async Task<ViewingInfoResponse> GetViewingInfoByIdAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ViewingInfoResponse>($"/{Version}/payments/{paymentId}/viewingInfo", cancellationToken);
            return result;
        }

        public async Task<PaymentResponse> GetPaymentByIdAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<PaymentResponse>($"/{Version}/payments/{paymentId}", cancellationToken);
            return result;
        }

        public async Task<IdentificationFieldResponse> GetIdentificationFieldAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<IdentificationFieldResponse>($"/{Version}/payments/{paymentId}/identificationField", cancellationToken);
            return result;
        }

        public async Task<PaymentResponse> ReceiveInCashAsync(string paymentId, ReceiveInCashRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentResponse>($"/{Version}/payments/{paymentId}/receiveInCash", request, cancellationToken);
            return result;
        }

        public async Task<PaymentResponse> UndoReceivedInCashAsync(string paymentId, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentResponse>($"/{Version}/payments/{paymentId}/undoReceivedInCash", null, cancellationToken);
            return result;
        }

        public async Task<SimulatePaymentResponse> SimulatePaymentAsync(SimulatePaymentRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<SimulatePaymentResponse>($"/{Version}/payments/simulate", request, cancellationToken);
            return result;
        }

        public async Task<PaymentLimitsResponse> GetPaymentLimitsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<PaymentLimitsResponse>($"/{Version}/payments/limits", cancellationToken);
            return result;
        }
    }
}
