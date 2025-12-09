using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentLink.Requests;
using WP.Asaas.Sdk.Models.PaymentLink.Responses;

namespace WP.Asaas.Sdk.Services;

public class PaymentsLinkService : IPaymentsLinkService
{
    private const string Version = "v3";
    private readonly IAsaasClient _asaasClient;
    public PaymentsLinkService(IAsaasClient asaasClient)
    {
        _asaasClient = asaasClient;
    }

    public async Task<PaymentLinkResponse> CreatePaymentLinkAsync(CreatePaymentLinkRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentLinkResponse>($"{Version}/paymentLinks", request, cancellationToken);
        return result;
    }

    public async Task<PaymentLinkListResponse> GetAllPaymentLinksAsync(CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PaymentLinkListResponse>($"{Version}/paymentLinks", cancellationToken);
        return result;
    }

    public async Task<PaymentLinkResponse> UpdatePaymentLinkAsync(string paymentLinkId, UpdatePaymentLinkRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PutAsync<PaymentLinkResponse>($"{Version}/paymentLinks/{paymentLinkId}", request, cancellationToken);
        return result;
    }

    public async Task<PaymentLinkResponse> GetPaymentLinksAsync(string paymentLinkId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PaymentLinkResponse>($"{Version}/paymentLinks/{paymentLinkId}", cancellationToken);
        return result;
    }

    public async Task<DeletedPaymentLinkResponse> DeletePaymentLinkAsync(string paymentLinkId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.DeleteAsync<DeletedPaymentLinkResponse>($"{Version}/paymentLinks/{paymentLinkId}", cancellationToken);
        return result;
    }

    public async Task<PaymentLinkResponse> RestorePaymentLinkAsync(string paymentLinkId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentLinkResponse>($"{Version}/paymentLinks/{paymentLinkId}/restore", null, cancellationToken);
        return result;
    }
}