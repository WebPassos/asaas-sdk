using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Common.Base;
using WP.Asaas.Sdk.Models.Customer;
using WP.Asaas.Sdk.Models.Customer.Requests;

namespace WP.Asaas.Sdk.Services
{
    public sealed class CustomerService : ICustomerService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;

        public CustomerService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
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
}
