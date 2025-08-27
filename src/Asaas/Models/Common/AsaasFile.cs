using WP.Asaas.Sdk.Commons;

namespace WP.Asaas.Sdk.Models.Common;

public class AsaasFile : IAsaasFile
{
    public string FileName { get; init; }

    public byte[] FileContent { get; init; }
}