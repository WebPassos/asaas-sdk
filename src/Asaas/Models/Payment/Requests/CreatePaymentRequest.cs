using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.Payment.Requests;

public class CreatePaymentRequest : BasePaymentRequest
{
    public string ExternalReference { get; init; }
    public int InstallmentCount { get; init; }
    public decimal InstallmentValue { get; init; }
    public bool PostalService { get; init; }
    public DateTime DueDate { get; init; }
    public CreditCardRequest CreditCard { get; init; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; init; }
    public string RemoteIp { get; init; }
    public Callback Callback { get; init; }
}