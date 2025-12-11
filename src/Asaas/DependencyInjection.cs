using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WP.Asaas.Sdk.Clients;
using WP.Asaas.Sdk.Configurations;
using WP.Asaas.Sdk.Helpers;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Services;

namespace WP.Asaas.Sdk
{
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
                var config = provider.GetRequiredService<AsaasConfiguration>();
            
                var baseUrl = config.BaseUrl.TrimEnd('/') + '/';
            
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.TryAddWithoutValidation("access_token", config.Token);
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", UserAgentHelper.GetRandomUserAgent());
                client.Timeout = config.TimeOut;
            });

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBillService, BillService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IFinanceService, FinanceService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IPaymentDunningService, PaymentDunningService>();
            services.AddScoped<IPaymentInstallmentService, PaymentInstallmentService>();
            services.AddScoped<IPaymentRefundService, PaymentRefundService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPaymentsLinkService, PaymentsLinkService>();
            services.AddScoped<IPixPaymentMethodService, PixPaymentMethodService>();
            services.AddScoped<ISubscriptionService, SubscriptionService>();
            services.AddScoped<ITransferService, TransferService>();
            services.AddScoped<IWebHookService, WebHookService>();

            return services;
        }
    }
}