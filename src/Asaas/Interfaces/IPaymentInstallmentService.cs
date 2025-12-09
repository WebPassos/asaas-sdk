using WP.Asaas.Sdk.Models.PaymentInstallment.Requests;
using WP.Asaas.Sdk.Models.PaymentInstallment.Responses;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface IPaymentInstallmentService
    {
        Task<PaymentInstallmentResponse> CreateInstallmentAsync(CreatePaymentInstallmentRequest request, CancellationToken cancellationToken);
        Task<PaymentInstallmentResponse> CreateCreditCardInstallmentAsync(CreateCreditCardInstallmentRequest request, CancellationToken cancellationToken);
        Task<PaymentInstallmentListResponse> GetAllInstallmentsAsync(CancellationToken cancellationToken);
        Task<DeletedInstallmentResponse> DeleteInstallmentAsync(string installmentId, CancellationToken cancellationToken);
        Task<byte[]> GenerateInstallmentPaymentBookAsync(string installmentId, CancellationToken cancellationToken);
        Task<PaymentInstallmentResponse> GetInstallmentByIdAsync(string installmentId, CancellationToken cancellationToken);
        Task<InstallmentPaymentListResponse> ListInstallmentPaymentsAsync(string installmentId, CancellationToken cancellationToken);
        Task<CreditCard> TokenizeCreditCardAsync(TokenizeCreditCardRequest request, CancellationToken cancellationToken);
    }
}
