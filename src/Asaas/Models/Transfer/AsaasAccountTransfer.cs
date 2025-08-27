using Asaas.Models.Transfer.Base;
using Asaas.Models.Transfer.Enums;

namespace Asaas.Models.Transfer;

public class AsaasAccountTransfer : BaseTransfer
{
    public string WalletId { get; set; }

    public AsaasAccountTransferStatus Status { get; set; }

    public AsaasAccount Account { get; set; }
}