namespace WP.Asaas.Sdk.Models.PaymentLink.Requests;

public class CreatePaymentLinkRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string EndDate { get; set; }
    public decimal? Value { get; set; }
    public string BillingType { get; set; }
    public string ChargeType { get; set; }
    public int? DueDateLimitDays { get; set; }
    public string SubscriptionCycle { get; set; }
    public int? MaxInstallmentCount { get; set; }
    public string ExternalReference { get; set; }
    public bool? NotificationEnabled { get; set; }
    public object Callback { get; set; }
    public bool? IsAddressRequired { get; set; }
}