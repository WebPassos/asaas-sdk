namespace Asaas.Configurations;

public class AsaasConfiguration
{
    public string WalletId { get; init; } = null!;
    public string Token { get; init; } = null!;
    public string BaseUrl { get; init; } = null!;
    public TimeSpan TimeOut { get; init; }
}