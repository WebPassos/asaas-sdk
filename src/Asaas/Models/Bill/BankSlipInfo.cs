namespace WP.Asaas.Sdk.Models.Bill
{
    public class BankSlipInfo
    {
        public string IdentificationField { get; init; }
        public decimal Value { get; init; }
        public DateTime DueDate { get; init; }
        public string CompanyName { get; init; }
        public string BankCode { get; init; }
    }
}