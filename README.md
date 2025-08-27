# AsaasSDK - Integração com a API Asaas
Esta biblioteca fornece uma integração simplificada com a API do Asaas para aplicações .NET, facilitando a implementação de funcionalidades de pagamento.

## Instalação
1. Configuração do appsettings.json
Adicione a configuração do Asaas no seu arquivo appsettings.json:
```json
{
    "AsaasConfiguration": {
        "WalletId": "seu_wallet_id",
        "Token": "seu_token_de_acesso",
        "BaseUrl": "https://www.asaas.com/api/v3/",
        "TimeOut": "00:00:30"
    }
}
```
2. Configuração da Injeção de Dependência
No arquivo Program.cs da sua aplicação, adicione a configuração do Asaas:
```csharp
using Asaas;
var builder = WebApplication.CreateBuilder(args);
// Configuração do Asaas
builder.Services.ConfigureAsaas(builder.Configuration);
// ... outras configurações
```


## Configuração
Parâmetros de Configuração
| Parâmetro | Descrição | Obrigatório |
|------------|--------------------------------------|-------------|
| WalletId | Identificador da sua carteira Asaas | Sim |
| Token | Token de acesso da API | Sim |
| BaseUrl | URL base da API Asaas | Sim |
| TimeOut | Timeout para requisições | Não |

## Como Usar
Exemplo de Uso do Serviço de Clientes
Após configurar a injeção de dependência, você pode injetar os serviços do Asaas em seus
controllers ou serviços:
```csharp
using Asaas.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace SeuProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}")]
        public async Task GetCustomer(string id)
        {
            try
            {
                var customer = await _customerService.GetByIdAsync(id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task CreateCustomer([FromBody] CustomerCreateRequest request)
        {
            try
            {
                var customer = await _customerService.CreateAsync(request);
                return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
```

## Serviços Disponíveis
Atualmente a biblioteca oferece os seguintes serviços:
- **ICustomerService**: Operações relacionadas a clientes
- `CreateAsync`: Criar um novo cliente
- `GetByIdAsync`: Buscar cliente por ID
- `UpdateAsync`: Atualizar cliente
- `DeleteAsync`: Deletar cliente
- `ListAllAsync`: Listar todos os clientes

## Extensibilidade
Adicionando Novos Serviços
Para adicionar novos serviços à biblioteca:
1. Crie a interface do serviço em `Asaas/Interfaces/`
2. Implemente a classe do serviço em `Asaas/Services/`
3. Registre o serviço no método `AddServices()` em `DependencyInjection.cs`:
```csharp
private static IServiceCollection AddServices(this IServiceCollection services)
{
    services.AddScoped<ICustomerService, CustomerService>();
    services.AddScoped<INovoService, NovoService>(); // Novo serviço
    return services;
}
```

## Solução de Problemas
Erros Comuns
- **Token inválido**: Verifique se o token está correto no appsettings.json
- **Timeout**: Ajuste o valor de `TimeOut` se necessário
- **URL incorreta**: Certifique-se de que a `BaseUrl` está apontando para o ambiente correto
(produção/sandbox)
Logs
A biblioteca utiliza o sistema de logging padrão do .NET. Para habilitar logs:
```csharp
// No Program.cs
builder.Logging.AddConsole();
```

## Exemplo Completo
```csharp
// Exemplo de criação de cliente
var customerRequest = new CustomerCreateRequest
{
    Name = "João Silva",
    Email = "joao@email.com",
    Phone = "4738010919",
    MobilePhone = "4799376637",
    CpfCnpj = "24971563792",
    PostalCode = "01310-000",
    Address = "Av. Paulista",
    AddressNumber = "150",
    Complement = "Sala 201",
    Province = "Centro",
    ExternalReference = "12987382",
    NotificationDisabled = false,
    AdditionalEmails = "joao2@email.com,joao3@email.com",
    MunicipalInscription = "466836959",
    StateInscription = "646681195275",
    Observations = "ótimo pagador, nenhum problema até o momento"
};
var result = await _customerService.CreateAsync(customerRequest);
```

## Contribuição
Contribuições são sempre bem-vindas! Por favor, leia o guia de contribuição antes de enviar um pull request.

## Suporte
Em caso de dúvidas ou problemas, abra uma issue no repositório do projeto.