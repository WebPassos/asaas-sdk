using WP.Asaas.Sdk.Enums;

namespace WP.Asaas.Sdk.Models.Transfer
{
    public class AsaasAccountTransfer 
    {
        public string WalletId { get; set; }

        public AsaasAccountTransferStatus Status { get; set; }

        public AsaasAccount Account { get; set; }
    }
}