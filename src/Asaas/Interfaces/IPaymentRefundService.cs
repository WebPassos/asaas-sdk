using WP.Asaas.Sdk.Models.PaymentRefund.Requests;
using WP.Asaas.Sdk.Models.PaymentRefund.Responses;

namespace WP.Asaas.Sdk.Interfaces
{
    public interface IPaymentRefundService
    {
        Task<PaymentRefundSlipResponse> ReversePaymentSlipAsync(string paymentId, CancellationToken cancellationToken);
        Task<InstallmentPaymentRefundResponse> ReverseInstallmentPaymentAsync(string installmentId, ReverseInstallmentPaymentRequest request, CancellationToken cancellationToken);
        Task<PaymentRefundResponse> ReversePaymentRefundAsync(string paymentId, ReverseChargeRequest request, CancellationToken cancellationToken);
        Task<PaymentRefundListResponse> GetAllPaymentRefundsAsync(string paymentId, CancellationToken cancellationToken);
    }
}
