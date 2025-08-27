using AsaasSdk.Models.Common;
using AsaasSdk.Models.Common.Enums;

namespace AsaasSdk.Models.Payment.Requests;

public class CreatePaymentRequest
{
    public string Customer { get; init; }
    public BillingType BillingType { get; init; }
    public decimal Value { get; init; }
    public DateTime? DueDate { get; init; }
    public string Description { get; init; }
    public string ExternalReference { get; init; }
    public int InstallmentCount { get; init; }
    public decimal InstallmentValue { get; init; }
    public Discount Discount { get; init; }
    public Interest Interest { get; init; }
    public Fine Fine { get; init; }
    public bool PostalService { get; init; }
    public CreditCardRequest CreditCard { get; init; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; init; }
    public string RemoteIp { get; init; }
    public List<Split> Split { get; init; }
}