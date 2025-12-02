using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Invoice.Requests;
using WP.Asaas.Sdk.Models.Invoice.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class InvoiceService : IInvoiceService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;

        public InvoiceService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<InvoiceResponse> CreateInvoiceAsync(CreateInvoiceRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<InvoiceResponse>($"/{Version}/invoices", request, cancellationToken);
            return result;
        }

        public async Task<ListInvoiceResponse> GetAllInvoicesAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListInvoiceResponse>($"/{Version}/invoices", cancellationToken);
            return result;
        }

        public async Task<InvoiceResponse> UpdateInvoiceAsync(string id, UpdateInvoiceRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PutAsync<InvoiceResponse>($"/{Version}/invoices/{id}", request, cancellationToken);
            return result;
        }

        public async Task<InvoiceResponse> GetInvoiceByIdAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<InvoiceResponse>($"/{Version}/invoices/{id}", cancellationToken);
            return result;
        }

        public async Task<InvoiceResponse> AuthorizeInvoiceAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<InvoiceResponse>($"/{Version}/invoices/{id}/authorize", null, cancellationToken);
            return result;
        }

        public async Task<InvoiceResponse> CancelInvoiceAsync(string id, CancelInvoiceRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<InvoiceResponse>($"/{Version}/invoices/{id}/cancel", request, cancellationToken);
            return result;
        }
    }
}
