using WP.Asaas.Sdk.Models.Transfer.Base;
using WP.Asaas.Sdk.Models.Transfer.Enums;

namespace WP.Asaas.Sdk.Models.Transfer;

public class AsaasAccountTransfer : BaseTransfer
{
    public string WalletId { get; set; }

    public AsaasAccountTransferStatus Status { get; set; }

    public AsaasAccount Account { get; set; }
}