using WP.Asaas.Sdk.Models.Customer.Requests;

namespace WP.Asaas.Sdk.Interfaces;

public interface ICustomerService
{
    Task<string> CreateCustomerAsync(CreateCustomerRequest payload, CancellationToken cancellationToken);
    Task<string> UpdateCustomerAsync(UpdateCustomerRequest payload, CancellationToken cancellationToken);
    Task<bool> DeleteCustomerAsync(string customerId, CancellationToken cancellationToken);
}