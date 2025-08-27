using Asaas.Models.Common;
using Asaas.Models.Common.Enums;
using Asaas.Models.Subscription.Enums;

namespace Asaas.Models.Subscription;

public class Subscription
{
    public string Id { get; init; }
    public DateTime DateCreated { get; init; }
    public string Customer { get; init; }
    public BillingType BillingType { get; init; }
    public decimal Value { get; init; }
    public DateTime NextDueDate { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public Cycle Cycle { get; init; }
    public string Description { get; init; }
    public DateTime? EndDate { get; init; }
    public int? MaxPayments { get; init; }
    public SubscriptionStatus Status { get; init; }
    public string ExternalReference { get; init; }
    public CreditCard CreditCard { get; init; }
    public bool Deleted { get; init; }
}