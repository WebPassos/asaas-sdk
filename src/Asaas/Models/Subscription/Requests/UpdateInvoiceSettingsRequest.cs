using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Subscription.Enums;

namespace WP.Asaas.Sdk.Models.Subscription.Requests;

public class UpdateInvoiceSettingsRequest
{
    public decimal Deductions { get; init; }
    public EffectiveDatePeriod EffectiveDatePeriod { get; init; }
    public bool ReceivedOnly { get; init; }
    public int DaysBeforeDueDate { get; init; }
    public string Observations { get; init; }
    public Taxes Taxes { get; init; }
}