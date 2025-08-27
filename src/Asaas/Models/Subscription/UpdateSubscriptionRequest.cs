using AsaasSdk.Models.Common;
using AsaasSdk.Models.Common.Enums;
using AsaasSdk.Models.Subscription.Enums;

namespace AsaasSdk.Models.Subscription;

public class UpdateSubscriptionRequest
{
    public BillingType? BillingType { get; init; }
    public decimal? Value { get; init; }
    public DateTime? NextDueDate { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public Cycle? Cycle { get; init; }
    public string Description { get; init; }
    public bool? UpdatePendingPayments { get; init; }
    public string ExternalReference { get; init; }
}