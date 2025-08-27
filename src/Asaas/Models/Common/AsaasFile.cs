using AsaasSdk.Commons;

namespace AsaasSdk.Models.Common;

public class AsaasFile : IAsaasFile
{
    public string FileName { get; init; }

    public byte[] FileContent { get; init; }
}