using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentRefund.Requests;
using WP.Asaas.Sdk.Models.PaymentRefund.Responses;

namespace WP.Asaas.Sdk.Services;

public class PaymentRefundService : IPaymentRefundService
{
    private const string Version = "v3";
    private readonly IAsaasClient _asaasClient;
    public PaymentRefundService(IAsaasClient asaasClient)
    {
        _asaasClient = asaasClient;
    }

    public async Task<PaymentRefundSlipResponse> ReversePaymentSlipAsync(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentRefundSlipResponse>($"{Version}/payments/{paymentId}/bankSlip/refund", null, cancellationToken);
        return result;
    }

    public async Task<InstallmentPaymentRefundResponse> ReverseInstallmentPaymentAsync(string installmentId, ReverseInstallmentPaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<InstallmentPaymentRefundResponse>($"{Version}/installments/{installmentId}/refund", request, cancellationToken);
        return result;
    }

    public async Task<PaymentRefundResponse> ReversePaymentRefundAsync(string paymentId, ReverseChargeRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentRefundResponse>($"{Version}/payments/{paymentId}/refund", request, cancellationToken);
        return result;
    }

    public async Task<PaymentRefundListResponse> GetAllPaymentRefundsAsync(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PaymentRefundListResponse>($"{Version}/payments/{paymentId}/refunds", cancellationToken);
        return result;
    }
}