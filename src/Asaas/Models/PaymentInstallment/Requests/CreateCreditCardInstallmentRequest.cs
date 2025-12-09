using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.PaymentInstallment.Requests;

public class CreateCreditCardInstallmentRequest : BasePaymentRequest
{
    public CreditCardRequest CreditCard { get; set; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }
    public DateTime DueDate { get; init; }
    public string CreditCardToken { get; set; }
    public bool? AuthorizeOnly { get; set; }
    public string RemoteIp { get; set; }
}