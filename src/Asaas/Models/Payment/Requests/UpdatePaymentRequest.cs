using WP.Asaas.Sdk.Models.Common.Base;

namespace WP.Asaas.Sdk.Models.Payment.Requests;

public class UpdatePaymentRequest : BasePaymentRequest
{
    public DateTime DueDate { get; init; }
    public bool? PostalService { get; init; }
}