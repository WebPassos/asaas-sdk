using AsaasSdk.Models.Common;
using AsaasSdk.Models.Common.Enums;
using AsaasSdk.Models.Subscription.Enums;

namespace AsaasSdk.Models.Subscription;

public class CreateSubscriptionRequest
{
    public string Customer { get; init; }
    public BillingType BillingType { get; init; }
    public decimal Value { get; init; }
    public DateTime NextDueDate { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public Cycle? Cycle { get; init; }
    public string Description { get; init; }
    public DateTime? EndDate { get; init; }
    public int? MaxPayments { get; init; }
    public string ExternalReference { get; init; }
    public CreditCardRequest CreditCard { get; init; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; init; }
    public string RemoteIp { get; init; }
}