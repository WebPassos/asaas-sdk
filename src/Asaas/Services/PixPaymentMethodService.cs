using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.PaymentPix.Requests;
using WP.Asaas.Sdk.Models.PaymentPix.Responses;

namespace WP.Asaas.Sdk.Services;

public class PixPaymentMethodService : IPixPaymentMethodService
{
    private const string Version = "v3";
    private readonly IAsaasClient _asaasClient;
    public PixPaymentMethodService(IAsaasClient asaasClient)
    {
        _asaasClient = asaasClient;
    }

    public async Task<PixQrCodeResponse> CreatePaymentPixQRCodeStaticAsync(PixQRCodeRequest payload, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PixQrCodeResponse>($"{Version}/pix/qrCodes/static", payload, cancellationToken);
        return result;
    }

    public async Task DeletePaymentPixQRCodeStaticAsync(string qrCodeId, CancellationToken cancellationToken)
    {
        await _asaasClient.DeleteAsync($"{Version}/pix/qrCodes/static/{qrCodeId}", cancellationToken);
    }

    public async Task<PixAddressKeyResponse> CreatePixAddressKeyAsync(CreatePixAddressKeyRequest request, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PixAddressKeyResponse>($"{Version}/pix/addressKeys", request, cancellationToken);
        return result;
    }

    public async Task DeletePixAddressKeyAsync(string addressKeyId, CancellationToken cancellationToken)
    {
        await _asaasClient.DeleteAsync($"{Version}/pix/addressKeys/{addressKeyId}", cancellationToken);
    }

    public async Task<PixAddressKeyListResponse> GetPixAddressKeysAsync(CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PixAddressKeyListResponse>($"{Version}/pix/addressKeys", cancellationToken);
        return result;
    }

    public async Task<PixAddressKeyResponse> GetPixAddressKeyByIdAsync(string addressKeyId, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.GetAsync<PixAddressKeyResponse>($"{Version}/pix/addressKeys/{addressKeyId}", cancellationToken);
        return result;
    }

    public async Task<PaymentPixQRCodeResponse> PaymentPixQRCodeAsync(PaymentPixQRCodeRequest payload, CancellationToken cancellationToken)
    {
        var result = await _asaasClient.PostAsync<PaymentPixQRCodeResponse>($"pix/qrCodes/pay", payload, cancellationToken);
        return result;
    }
}