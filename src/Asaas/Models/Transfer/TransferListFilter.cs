using AsaasSdk.Models.Common;
using AsaasSdk.Models.Transfer.Enums;

namespace AsaasSdk.Models.Transfer;

public class TransferListFilter : RequestParameters
{
    public DateTime? DateCreated
    {
        get => Get<DateTime?>("dateCreated");
        set => Add("dateCreated", value);
    }

    public TransferType? TransferType
    {
        get => Get<TransferType?>("type");
        set => Add("type", value);
    }
}