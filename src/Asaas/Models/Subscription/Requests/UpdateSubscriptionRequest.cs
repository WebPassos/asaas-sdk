using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.Common.Enums;
using WP.Asaas.Sdk.Models.Subscription.Enums;

namespace WP.Asaas.Sdk.Models.Subscription.Requests
{
    public class UpdateSubscriptionRequest : BasePaymentRequest
    {
        public StatusType Status { get; init; }
        public DateTime? NextDueDate { get; init; }
        public Cycle? Cycle { get; init; }
        public DateTime? EndDate { get; init; }
        public bool? UpdatePendingPayments { get; init; }
        public string ExternalReference { get; init; }
        public Callback Callback { get; init; }
    }
}
