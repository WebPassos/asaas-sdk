namespace WP.Asaas.Sdk.Models.Bill.Requests
{
    public class CreateBillPaymentRequest
    {
        public string IdentificationField { get; init; }
        public DateTime ScheduleDate { get; init; }
        public string Description { get; init; }
        public decimal Discount { get; init; }
        public DateTime DueDate { get; init; }
        public string Interest { get; init; }
        public string Fine { get; init; }
        public decimal Value { get; init; }
    }
}