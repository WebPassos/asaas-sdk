namespace Asaas.Models.Bill;

public class CreateBillPaymentRequest
{
    public string IdentificationField { get; init; }
    public DateTime ScheduleDate { get; init; }
    public string Description { get; init; }
    public decimal Discount { get; init; }
    public DateTime DueDate { get; init; }
    public decimal Value { get; init; }
}