using AsaasSdk.Commons;
using AsaasSdk.Configurations;
using AsaasSdk.Helpers;
using AsaasSdk.Interfaces;
using AsaasSdk.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AsaasSdk;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureAsaas(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAsaasClient(configuration);
        services.AddServices();
        return services;
    }

    private static IServiceCollection AddAsaasClient(this IServiceCollection services, IConfiguration configuration)
    {
        AsaasConfiguration asaasConfig = new();
        configuration.GetSection("AsaasConfiguration").Bind(asaasConfig);
        services.AddSingleton(asaasConfig);
        services.AddHttpClient<IAsaasClient, AsaasClient>((provider, client) =>
        {
            AsaasConfiguration config = provider.GetRequiredService<AsaasConfiguration>();
            client.BaseAddress = new Uri(config.BaseUrl);
            client.DefaultRequestHeaders.TryAddWithoutValidation("access_token", config.Token);
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", UserAgentHelper.GetRandomUserAgent());
            client.Timeout = config.TimeOut;
        });

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();

        return services;
    }
}