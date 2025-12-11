namespace WP.Asaas.Sdk.Interfaces
{
    public interface IAsaasFile
    {
        string FileName { get; init; }
        byte[] FileContent { get; init; }
    }
}