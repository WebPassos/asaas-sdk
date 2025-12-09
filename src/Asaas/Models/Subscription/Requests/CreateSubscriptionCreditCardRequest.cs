using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.Subscription.Enums;

namespace WP.Asaas.Sdk.Models.Subscription.Requests;

public class CreateSubscriptionCreditCardRequest : BasePaymentRequest
{
    public Cycle? Cycle { get; init; }
    public DateTime? EndDate { get; init; }
    public int? MaxPayments { get; init; }
    public DateTime NextDueDate { get; init; }
    public string ExternalReference { get; init; }
    public Callback Callback { get; init; }
    public CreditCardRequest CreditCard { get; init; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; init; }
    public string CreditCardToken { get; init; }
    public string RemoteIp { get; init; }
}