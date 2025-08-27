using Asaas.Models.Common;
using Asaas.Models.Common.Enums;
using Asaas.Models.Subscription.Enums;

namespace Asaas.Models.Subscription;

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