using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Subscription
{
    public class SubscriptionInvoiceListFilter : RequestParameters
    {
        public InvoiceStatus? InvoiceStatus
        {
            get => Get<InvoiceStatus?>("status");
            set => Add("status", value);
        }
    }
}