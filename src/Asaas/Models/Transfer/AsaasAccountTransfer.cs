using AsaasSdk.Models.Transfer.Base;
using AsaasSdk.Models.Transfer.Enums;

namespace AsaasSdk.Models.Transfer;

public class AsaasAccountTransfer : BaseTransfer
{
    public string WalletId { get; set; }

    public AsaasAccountTransferStatus Status { get; set; }

    public AsaasAccount Account { get; set; }
}