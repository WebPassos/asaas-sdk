using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.Transfer.Enums;

namespace WP.Asaas.Sdk.Models.Transfer.Responses;

public class TransferResponse : BasePaymentResponse
{
    public string Object { get; set; }
    public TransferType Type { get; set; }
    public double NetValue { get; set; }
    public double TransferFee { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime ScheduleDate { get; set; }
    public string EndToEndIdentifier { get; set; }
    public bool Authorized { get; set; }
    public string FailReason { get; set; }
    public string TransactionReceiptUrl { get; set; }
    public OperationType OperationType { get; set; }
    public Recurring Recurring { get; set; }
    public BankAccountResponse BankAccount { get; set; }
}