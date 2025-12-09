using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.PaymentDunning.Requests;
using WP.Asaas.Sdk.Models.PaymentDunning.Responses;

namespace WP.Asaas.Sdk.Interfaces;

public interface IPaymentDunningService
{
    Task<PaymentDunningResponse> CreatePaymentDunningAsync(CreatePaymentDunningRequest request, CancellationToken cancellationToken);
    Task<ListPaymentDunningResponse> GetAllPaymentDunningsAsync(CancellationToken cancellationToken);
    Task<SimulatedPaymentDunningResponse> SimulatePaymentDunningAsync(SimulatePaymentDunningRequest request, CancellationToken cancellationToken);
    Task<PaymentDunningResponse> GetPaymentDunningByIdAsync(string id, CancellationToken cancellationToken);
    Task<ListPaymentDunningEventHistoryResponse> GetPaymentDunningEventHistoryAsync(string id, CancellationToken cancellationToken);
    Task<ListPaymentDunningPartialPaymentResponse> GetPaymentDunningPartialPaymentsAsync(string id, CancellationToken cancellationToken);
    Task<ListPaymentAvailableForDunningResponse> GetPaymentsAvailableForDunningAsync(CancellationToken cancellationToken);
    Task<PaymentDunningResponse> SendDocumentsAsync(string id, DocumentsRequest request, CancellationToken cancellationToken);
    Task<PaymentDunningResponse> CancelPaymentDunningAsync(string id, CancellationToken cancellationToken);
}