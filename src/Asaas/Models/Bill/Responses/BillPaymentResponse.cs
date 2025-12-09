using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.Bill.Responses
{
    public class BillPaymentResponse
    {
        public string Id { get; init; }
        public BillPaymentStatus Status { get; init; }
        public decimal Value { get; init; }
        public decimal Discount { get; init; }
        public string IdentificationField { get; init; }
        public DateTime DueDate { get; init; }
        public DateTime ScheduleDate { get; init; }
        public decimal Fee { get; init; }
        public string Description { get; init; }
        public string CompanyName { get; init; }
        public string TransactionReceiptUrl { get; init; }
        public bool CanBeCancelled { get; init; }
        public string FailReasons { get; init; }
    }
}