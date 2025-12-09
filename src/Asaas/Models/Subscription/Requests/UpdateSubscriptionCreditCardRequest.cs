using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Subscription.Requests
{
    public class UpdateSubscriptionCreditCardRequest
    {
        public CreditCardRequest CreditCard { get; init; }
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; init; }
        public string CreditCardToken { get; init; }
        public string RemoteIp { get; init; }
    }
}