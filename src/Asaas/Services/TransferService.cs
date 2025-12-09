using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Transfer.Requests;
using WP.Asaas.Sdk.Models.Transfer.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class TransferService : ITransferService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;
        public TransferService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<TransferResponse> TransferAsync(CreateTransferRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<TransferResponse>($"{Version}/transfers", request, cancellationToken);
            return result;
        }

        public async Task<TransferListResponse> GetAllTransfersAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<TransferListResponse>($"{Version}/transfers", cancellationToken);
            return result;
        }

        public async Task<AsaasAccountTransferResponse> CreateAsaasAccountTransferAsync(AsaasAccountTransferRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<AsaasAccountTransferResponse>($"{Version}/transfers", request, cancellationToken);
            return result;
        }

        public async Task<TransferResponse> CancelTransferAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<TransferResponse>($"{Version}/transfers/{id}/cancel", null, cancellationToken);
            return result;
        }

        public async Task<TransferResponse> GetTransfersByIdAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<TransferResponse>($"{Version}/transfers/{id}", cancellationToken);
            return result;
        }
    }
}