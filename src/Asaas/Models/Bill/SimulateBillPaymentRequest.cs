namespace Asaas.Models.Bill;

public class SimulateBillPaymentRequest
{
    public string IdentificationField { get; init; }
    public string BarCode { get; init; }
}