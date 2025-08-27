using Asaas.Models.Common;
using Asaas.Models.Common.Enums;

namespace Asaas.Models.Subscription;

public class SubscriptionListFilter : RequestParameters
{
    public string CustomerId
    {
        get => this["customer"];
        set => Add("customer", value);
    }

    public BillingType? BillingType
    {
        get => Get<BillingType?>("billingType");
        set => Add("billingType", value);
    }

    public bool? IncludeDeleted
    {
        get => Get<bool?>("includeDeleted");
        set => Add("includeDeleted", value);
    }
}