using WP.Asaas.Sdk.Models.Common.Enums;

namespace WP.Asaas.Sdk.Models.Common;

public class Fine
{
    public double Value { get; init; }
    public FineType Type { get; init; }
}