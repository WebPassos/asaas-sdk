namespace Asaas.Models.Bill;

public class SimulatedBillPayment
{
    public DateTime MinimumScheduleDate { get; init; }
    public decimal Fee { get; init; }
    public BankSlipInfo BankSlipInfo { get; init; }
}