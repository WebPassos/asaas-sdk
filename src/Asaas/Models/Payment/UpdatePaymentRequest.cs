using AsaasSdk.Models.Common;
using AsaasSdk.Models.Common.Enums;

namespace AsaasSdk.Models.Payment;

public class UpdatePaymentRequest
{
    public string Customer { get; init; }
    public BillingType? BillingType { get; init; }
    public decimal? Value { get; init; }
    public DateTime? DueDate { get; init; }
    public string Description { get; init; }
    public int? InstallmentCount { get; init; }
    public decimal? InstallmentValue { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public bool? PostalService { get; init; }
}