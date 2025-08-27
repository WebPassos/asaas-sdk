using Asaas.Models.Customer.Requests;

namespace Asaas.Interfaces;

public interface ICustomerService
{
    Task<string> CreateMinimalCustomerAsync(CreateCustomerRequest payload, CancellationToken cancellationToken);
    Task<string> CreateCustomerAsync(CreateCustomerRequest payload, CancellationToken cancellationToken);
    Task<string> UpdateCustomerAsync(UpdateCustomerRequest payload, CancellationToken cancellationToken);
    Task<bool> DeleteCustomerAsync(string customerId, CancellationToken cancellationToken);

}