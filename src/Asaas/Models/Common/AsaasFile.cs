using Asaas.Commons;

namespace Asaas.Models.Common;

public class AsaasFile : IAsaasFile
{
    public string FileName { get; init; }

    public byte[] FileContent { get; init; }
}