using Scalar.AspNetCore;
using WP.Asaas.Sdk;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddOpenApi(options =>
{
    options.AddDocumentTransformer((document, _, _) =>
    {
        document.Info = new()
        {
            Title = "Asaas Integration Tests API",
            Version = "v1",
            Description = "API para testar todos os métodos do Asaas SDK. Esta API permite testar integrações com pagamentos, clientes, cobranças, PIX, transferências e muito mais."
        };
        return Task.CompletedTask;
    });
});

builder.Services.ConfigureAsaas(configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options
            .WithTitle("Asaas Integration Tests API")
            .WithTheme(ScalarTheme.Purple)
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
