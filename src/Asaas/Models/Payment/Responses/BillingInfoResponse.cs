using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Bill;

namespace WP.Asaas.Sdk.Models.Payment.Responses;

public class BillingInfoResponse
{
    public PixBillingInfoResponse Pix { get; init; }
    public CreditCard CreditCard { get; init; }
    public BankSlipInfo BankSlip { get; init; }
}
