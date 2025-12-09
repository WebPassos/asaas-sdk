using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.Transfer
{
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
}