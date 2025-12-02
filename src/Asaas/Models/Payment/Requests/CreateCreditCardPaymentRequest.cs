using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.Payment.Requests;

public class CreateCreditCardPaymentRequest : BasePaymentRequest
{
    public string RemoteIp { get; set; }
    public string ExternalReference { get; set; }
    public int? InstallmentCount { get; set; }
    public decimal? TotalValue { get; set; }
    public decimal? InstallmentValue { get; set; }
    public bool PostalService { get; set; }
    public Callback Callback { get; set; }
    public CreditCardRequest CreditCard { get; set; }
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }
    public string CreditCardToken { get; set; }
    public bool AuthorizeOnly { get; set; }
    public DateTime DueDate { get; set; }
    public int? DaysAfterDueDateToRegistrationCancellation { get; set; }
}
