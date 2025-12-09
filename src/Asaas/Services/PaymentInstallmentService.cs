using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentInstallment.Requests;
using WP.Asaas.Sdk.Models.PaymentInstallment.Responses;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Services;

public class PaymentInstallmentService : IPaymentInstallmentService
{
    private const string Version = "v3";
    private readonly IAsaasClient _asaasClient;
    public PaymentInstallmentService(IAsaasClient asaasClient)
    {
        _asaasClient = asaasClient;
    }

    public async Task<PaymentInstallmentResponse> CreateInstallmentAsync(CreatePaymentInstallmentRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentInstallmentResponse>($"{Version}/installments", request, cancellationToken);
        return result;
    }

    public async Task<PaymentInstallmentResponse> CreateCreditCardInstallmentAsync(CreateCreditCardInstallmentRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentInstallmentResponse>($"{Version}/installments", request, cancellationToken);
        return result;
    }

    public async Task<PaymentInstallmentListResponse> GetAllInstallmentsAsync(CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PaymentInstallmentListResponse>($"{Version}/installments", cancellationToken);
        return result;
    }

    public async Task<DeletedInstallmentResponse> DeleteInstallmentAsync(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.DeleteAsync<DeletedInstallmentResponse>($"{Version}/installments/{installmentId}", cancellationToken);
        return result;
    }

    public async Task<byte[]> GenerateInstallmentPaymentBookAsync(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<byte[]>($"{Version}/installments/{installmentId}/paymentBook", cancellationToken);
        return result;
    }

    public async Task<PaymentInstallmentResponse> GetInstallmentByIdAsync(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PaymentInstallmentResponse>($"{Version}/installments/{installmentId}", cancellationToken);
        return result;
    }

    public async Task<InstallmentPaymentListResponse> ListInstallmentPaymentsAsync(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<InstallmentPaymentListResponse>($"{Version}/installments/{installmentId}/payments", cancellationToken);
        return result;
    }

    public async Task<CreditCard> TokenizeCreditCardAsync(TokenizeCreditCardRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<CreditCard>($"{Version}/installments/tokenizeCreditCard", request, cancellationToken);
        return result;
    }
}