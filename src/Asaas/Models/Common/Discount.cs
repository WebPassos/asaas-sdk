using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.Common
{
    public class Discount
    {
        public double Value { get; init; }
        public int DueDateLimitDays { get; init; }
        public DiscountType Type { get; init; }
    }
}