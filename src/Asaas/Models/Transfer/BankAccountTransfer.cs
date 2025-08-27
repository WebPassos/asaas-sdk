using AsaasSdk.Models.Transfer.Base;
using AsaasSdk.Models.Transfer.Enums;

namespace AsaasSdk.Models.Transfer;

public class BankAccountTransfer : BaseTransfer
{
    public decimal NetValue { get; set; }

    public BankAccountTransferStatus Status { get; set; }

    public BankAccount BankAccount { get; set; }
}