using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Requests
{
    public class TokenizeCreditCardRequest
    {
        public string Customer { get; set; }
        public CreditCardRequest CreditCard { get; set; }
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }
        public string RemoteIp { get; set; }
    }
}
