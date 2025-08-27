using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Subscription.Enums;

namespace WP.Asaas.Sdk.Models.Subscription;

public class SubscriptionInvoiceSettings
{
    public string MunicipalServiceId { get; init; }
    public string MunicipalServiceCode { get; init; }
    public string MunicipalServiceName { get; init; }
    public decimal Deductions { get; init; }
    public EffectiveDatePeriod InvoiceCreationPeriod { get; init; }
    public int DaysBeforeDueDate { get; init; }
    public bool ReceivedOnly { get; init; }
    public string Observations { get; init; }
    public Taxes Taxes { get; init; }
}