using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Payment.Requests;

public class PayWithCreditCardRequest
{
    public CreditCardRequest CreditCard { get; set; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }
    public string CreditCardToken { get; set; }
}
