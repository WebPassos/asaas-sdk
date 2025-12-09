using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Enums;

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