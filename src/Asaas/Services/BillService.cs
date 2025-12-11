using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Bill.Requests;
using WP.Asaas.Sdk.Models.Bill.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class BillService : IBillService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;

        public BillService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<BillPaymentResponse> CreateBillPaymentAsync(CreateBillPaymentRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<BillPaymentResponse>($"{Version}/bill", request, cancellationToken);
            return result;
        }

        public async Task<ListBillPaymentResponse> GetAllBillPaymentsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<ListBillPaymentResponse>($"{Version}/bill", cancellationToken);
            return result;
        }

        public async Task<SimulatedBillPaymentResponse> SimulateBillPaymentAsync(SimulateBillPaymentRequest request, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<SimulatedBillPaymentResponse>($"{Version}/bill/simulate", request, cancellationToken);
            return result;
        }

        public async Task<BillPaymentResponse> GetBillPaymentByIdAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<BillPaymentResponse>($"{Version}/bill/{id}", cancellationToken);
            return result;
        }

        public async Task<BillPaymentResponse> CancelBillPaymentAsync(string id, CancellationToken cancellationToken)
        {
            var result = await _asaasClient.PostAsync<BillPaymentResponse>($"{Version}/bill/{id}/cancel", null, cancellationToken);
            return result;
        }
    }
}