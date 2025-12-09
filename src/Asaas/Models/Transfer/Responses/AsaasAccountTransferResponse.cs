namespace WP.Asaas.Sdk.Models.Transfer.Responses;

public class AsaasAccountTransferResponse : TransferResponse
{
    public string WalletId { get; set; }
    public BankAccount Account { get; set; }
}