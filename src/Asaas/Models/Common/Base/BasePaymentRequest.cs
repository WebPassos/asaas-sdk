using WP.Asaas.Sdk.Models.Common.Enums;

namespace WP.Asaas.Sdk.Models.Common.Base;

public class BasePaymentRequest
{
    public string Customer { get; init; }
    public BillingType BillingType { get; init; }
    public decimal Value { get; init; }
    public string Description { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public List<Split> Split { get; init; }
}