using WP.Asaas.Sdk.Enums;
using WP.Asaas.Sdk.Models.Common;

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