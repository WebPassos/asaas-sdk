using WP.Asaas.Sdk.Models.Bill.Requests;
using WP.Asaas.Sdk.Models.Bill.Responses;

namespace WP.Asaas.Sdk.Interfaces;

public interface IBillService
{
    Task<BillPaymentResponse> CreateBillPaymentAsync(CreateBillPaymentRequest request, CancellationToken cancellationToken);
    Task<ListBillPaymentResponse> GetAllBillPaymentsAsync(CancellationToken cancellationToken);
    Task<SimulatedBillPaymentResponse> SimulateBillPaymentAsync(SimulateBillPaymentRequest request, CancellationToken cancellationToken);
    Task<BillPaymentResponse> GetBillPaymentByIdAsync(string id, CancellationToken cancellationToken);
    Task<BillPaymentResponse> CancelBillPaymentAsync(string id, CancellationToken cancellationToken);
}