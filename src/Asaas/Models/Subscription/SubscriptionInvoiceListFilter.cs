using AsaasSdk.Models.Common;
using AsaasSdk.Models.Invoice.Enums;

namespace AsaasSdk.Models.Subscription;

public class SubscriptionInvoiceListFilter : RequestParameters
{
    public InvoiceStatus? InvoiceStatus
    {
        get => Get<InvoiceStatus?>("status");
        set => Add("status", value);
    }
}