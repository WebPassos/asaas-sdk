using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Requests
{
    public class CreatePaymentInstallmentRequest : BasePaymentRequest
    {
        public int InstallmentCount { get; set; }
        public decimal? TotalValue { get; set; }
        public int? ExpirationDay { get; set; }
        public string PaymentExternalReference { get; set; }
    }
}
