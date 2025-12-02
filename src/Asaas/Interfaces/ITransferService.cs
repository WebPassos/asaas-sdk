using WP.Asaas.Sdk.Models.Transfer.Requests;
using WP.Asaas.Sdk.Models.Transfer.Responses;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface ITransferService
    {
        Task<TransferResponse> TransferAsync(CreateTransferRequest request, CancellationToken cancellationToken);
        Task<TransferListResponse> GetAllTransfersAsync(CancellationToken cancellationToken);
        Task<AsaasAccountTransferResponse> CreateAsaasAccountTransferAsync(AsaasAccountTransferRequest request, CancellationToken cancellationToken);
        Task<TransferResponse> CancelTransferAsync(string id, CancellationToken cancellationToken);
        Task<TransferResponse> GetTransfersByIdAsync(string id, CancellationToken cancellationToken);
    }
}
