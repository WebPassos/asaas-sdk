using Asaas.Models.Common;
using Asaas.Models.Invoice.Enums;

namespace Asaas.Models.Subscription;

public class SubscriptionInvoiceListFilter : RequestParameters
{
    public InvoiceStatus? InvoiceStatus
    {
        get => Get<InvoiceStatus?>("status");
        set => Add("status", value);
    }
}