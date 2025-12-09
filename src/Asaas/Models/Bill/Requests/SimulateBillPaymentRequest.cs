namespace WP.Asaas.Sdk.Models.Bill.Requests
{
    public class SimulateBillPaymentRequest
    {
        public string IdentificationField { get; init; }
        public string BarCode { get; init; }
    }
}