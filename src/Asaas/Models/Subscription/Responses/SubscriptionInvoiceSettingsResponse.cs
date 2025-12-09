using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Subscription.Responses
{
    public class SubscriptionInvoiceSettingsResponse
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
}