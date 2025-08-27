using AsaasSdk.Models.Common;
using AsaasSdk.Models.Subscription.Enums;

namespace AsaasSdk.Models.Subscription;

public class UpdateInvoiceSettingsRequest
{
    public decimal Deductions { get; init; }
    public EffectiveDatePeriod EffectiveDatePeriod { get; init; }
    public bool ReceivedOnly { get; init; }
    public int DaysBeforeDueDate { get; init; }
    public string Observations { get; init; }
    public Taxes Taxes { get; init; }
}