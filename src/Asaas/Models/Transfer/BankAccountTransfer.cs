using Asaas.Models.Transfer.Base;
using Asaas.Models.Transfer.Enums;

namespace Asaas.Models.Transfer;

public class BankAccountTransfer : BaseTransfer
{
    public decimal NetValue { get; set; }

    public BankAccountTransferStatus Status { get; set; }

    public BankAccount BankAccount { get; set; }
}