using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.PaymentPix.Requests;
using WP.Asaas.Sdk.Models.PaymentPix.Responses;

namespace WP.Asaas.Sdk.Interfaces;

public interface IPixPaymentMethodService
{
    Task<PixQrCodeResponse> CreatePaymentPixQRCodeStaticAsync(PixQRCodeRequest payload, CancellationToken cancellationToken);
    Task DeletePaymentPixQRCodeStaticAsync(string qrCodeId, CancellationToken cancellationToken);
    Task<PixAddressKeyResponse> CreatePixAddressKeyAsync(CreatePixAddressKeyRequest payload, CancellationToken cancellationToken);
    Task DeletePixAddressKeyAsync(string addressKeyId, CancellationToken cancellationToken);
    Task<PixAddressKeyListResponse> GetPixAddressKeysAsync(CancellationToken cancellationToken);
    Task<PixAddressKeyResponse> GetPixAddressKeyByIdAsync(string addressKeyId, CancellationToken cancellationToken);
    Task<PaymentPixQRCodeResponse> PaymentPixQRCodeAsync(PaymentPixQRCodeRequest payload, CancellationToken cancellationToken);
}