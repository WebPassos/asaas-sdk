using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.Subscription.Enums;

namespace WP.Asaas.Sdk.Models.Subscription.Responses;

public class SubscriptionResponse : BasePaymentResponse
{
    public string Object { get; set; }
    public string PaymentLink { get; set; }
    public Cycle Cycle { get; set; }
    public DateTime NextDueDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string CheckoutSession { get; set; }
    public int? MaxPayments { get; set; }
}