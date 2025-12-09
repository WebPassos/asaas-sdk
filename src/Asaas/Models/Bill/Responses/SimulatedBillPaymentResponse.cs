namespace WP.Asaas.Sdk.Models.Bill.Responses
{
    public class SimulatedBillPaymentResponse
    {
        public DateTime barCode { get; init; }
        public decimal Fee { get; init; }
        public BankSlipInfo BankSlipInfo { get; init; }
    }
}