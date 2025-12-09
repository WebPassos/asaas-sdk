using WP.Asaas.Sdk.Models.Invoice.Requests;
using WP.Asaas.Sdk.Models.Invoice.Responses;

namespace WP.Asaas.Sdk.Interfaces;

public interface IInvoiceService
{
    Task<InvoiceResponse> CreateInvoiceAsync(CreateInvoiceRequest request, CancellationToken cancellationToken);
    Task<ListInvoiceResponse> GetAllInvoicesAsync(CancellationToken cancellationToken);
    Task<InvoiceResponse> UpdateInvoiceAsync(string id, UpdateInvoiceRequest request, CancellationToken cancellationToken);
    Task<InvoiceResponse> GetInvoiceByIdAsync(string id, CancellationToken cancellationToken);
    Task<InvoiceResponse> AuthorizeInvoiceAsync(string id, CancellationToken cancellationToken);
    Task<InvoiceResponse> CancelInvoiceAsync(string id, CancelInvoiceRequest request, CancellationToken cancellationToken);
}