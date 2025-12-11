namespace WP.Asaas.Sdk.Interfaces
{
    public interface IAsaasClient
    {
        Task<TResponse> PostAsync<TResponse>(string endpoint, object payload, CancellationToken cancellationToken);
        Task PostAsync(string endpoint, object payload, CancellationToken cancellationToken);
        Task<TResponse> DeleteAsync<TResponse>(string endpoint, CancellationToken cancellationToken);
        Task DeleteAsync(string endpoint, CancellationToken cancellationToken);
        Task<TResponse> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken);
        Task<TResponse> PutAsync<TResponse>(string endpoint, object payload, CancellationToken cancellationToken);
        Task PutAsync(string endpoint, object payload, CancellationToken cancellationToken);
        Task PatchAsync(string endpoint, object payload, CancellationToken cancellationToken);
        Task<TResponse> PatchAsync<TResponse>(string endpoint, object payload, CancellationToken cancellationToken);
    }
}