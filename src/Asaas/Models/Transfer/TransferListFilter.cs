using Asaas.Models.Common;
using Asaas.Models.Transfer.Enums;

namespace Asaas.Models.Transfer;

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