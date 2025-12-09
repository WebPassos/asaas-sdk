using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.PaymentDunning.Requests;
using WP.Asaas.Sdk.Models.PaymentDunning.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class PaymentDunningService : IPaymentDunningService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;

        public PaymentDunningService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<PaymentDunningResponse> CreatePaymentDunningAsync(CreatePaymentDunningRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentDunningResponse>($"{Version}/paymentDunnings", request, cancellationToken);
            return result;
        }

        public async Task<ListPaymentDunningResponse> GetAllPaymentDunningsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListPaymentDunningResponse>($"{Version}/paymentDunnings", cancellationToken);
            return result;
        }

        public async Task<SimulatedPaymentDunningResponse> SimulatePaymentDunningAsync(SimulatePaymentDunningRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<SimulatedPaymentDunningResponse>($"{Version}/paymentDunnings/simulate", request, cancellationToken);
            return result;
        }

        public async Task<PaymentDunningResponse> GetPaymentDunningByIdAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<PaymentDunningResponse>($"{Version}/paymentDunnings/{id}", cancellationToken);
            return result;
        }

        public async Task<ListPaymentDunningEventHistoryResponse> GetPaymentDunningEventHistoryAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListPaymentDunningEventHistoryResponse>($"{Version}/paymentDunnings/{id}/history", cancellationToken);
            return result;
        }

        public async Task<ListPaymentDunningPartialPaymentResponse> GetPaymentDunningPartialPaymentsAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListPaymentDunningPartialPaymentResponse>($"{Version}/paymentDunnings/{id}/partialPayments", cancellationToken);
            return result;
        }

        public async Task<ListPaymentAvailableForDunningResponse> GetPaymentsAvailableForDunningAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListPaymentAvailableForDunningResponse>($"{Version}/paymentDunnings/paymentsAvailableForDunning", cancellationToken);
            return result;
        }

        public async Task<PaymentDunningResponse> SendDocumentsAsync(string id, DocumentsRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentDunningResponse>($"{Version}/paymentDunnings/{id}/documents", request, cancellationToken);
            return result;
        }

        public async Task<PaymentDunningResponse> CancelPaymentDunningAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<PaymentDunningResponse>($"{Version}/paymentDunnings/{id}/cancel", null, cancellationToken);
            return result;
        }
    }
}
