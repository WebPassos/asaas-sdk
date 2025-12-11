using WP.Asaas.Sdk.Enums;

namespace WP.Asaas.Sdk.Models.Transfer
{
    public class BankAccountTransfer 
    {
        public double NetValue { get; set; }

        public BankAccountTransferStatus Status { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}