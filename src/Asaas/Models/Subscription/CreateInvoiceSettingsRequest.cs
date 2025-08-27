using Asaas.Models.Common;
using Asaas.Models.Subscription.Enums;

namespace Asaas.Models.Subscription;

public class CreateInvoiceSettingsRequest
{
    public string MunicipalServiceId { get; init; }
    public string MunicipalServiceCode { get; init; }
    public string MunicipalServiceName { get; init; }
    public decimal Deductions { get; init; }
    public EffectiveDatePeriod EffectiveDatePeriod { get; init; }
    public int DaysBeforeDueDate { get; init; }
    public bool ReceivedOnly { get; init; }
    public string Observations { get; init; }
    public Taxes Taxes { get; init; }
}