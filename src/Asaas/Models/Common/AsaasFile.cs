using WP.Asaas.Sdk.Interfaces;

namespace WP.Asaas.Sdk.Models.Common
{
    public class AsaasFile : IAsaasFile
    {
        public string FileName { get; init; }

        public byte[] FileContent { get; init; }
    }
}