using Asaas.Commons;
using Asaas.Interfaces;
using Asaas.Models.Common.Base;
using Asaas.Models.Customer;
using Asaas.Models.Customer.Requests;

namespace Asaas.Services;

public sealed class CustomerService : ICustomerService
{
    private const string Version = "v3";
    private readonly IAsaasClient _asaasClient;

    public CustomerService(IAsaasClient asaasClient)
    {
        _asaasClient = asaasClient;
    }

    public async Task<string> CreateMinimalCustomerAsync(CreateCustomerRequest payload, CancellationToken cancellationToken)
    {
        var response = await _asaasClient.PostAsync<Customer>($"{Version}/customers", payload, cancellationToken);
        return response.Id;
    }

    public async Task<string> CreateCustomerAsync(CreateCustomerRequest payload, CancellationToken cancellationToken)
    {
        var response = await _asaasClient.PostAsync<Customer>($"{Version}/customers", payload, cancellationToken);
        return response.Id;
    }

    public async Task<string> UpdateCustomerAsync(UpdateCustomerRequest payload, CancellationToken cancellationToken)
    {
        var response = await _asaasClient.PostAsync<Customer>($"{Version}/customers/{payload.Id}", payload,
                cancellationToken);
        return response.Id;
    }

    public async Task<bool> DeleteCustomerAsync(string customerId, CancellationToken cancellationToken)
    {
        var response =  await _asaasClient.DeleteAsync<BaseDeleted>($"{Version}/customers/{customerId}", cancellationToken);
        return response.Deleted;
    }
}