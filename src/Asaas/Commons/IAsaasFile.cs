namespace AsaasSdk.Commons;

public interface IAsaasFile
{
    string FileName { get; init; }
    byte[] FileContent { get; init; }
}