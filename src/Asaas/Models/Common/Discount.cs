using Asaas.Models.Common.Enums;

namespace Asaas.Models.Common;

public class Discount
{
    public decimal Value { get; init; }
    public int DueDateLimitDays { get; init; }
    public DiscountType Type { get; init; }
}