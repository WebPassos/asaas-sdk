using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Asaas.Commons;

internal class AsaasClient : IAsaasClient
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
    };

    private readonly HttpClient _httpClient;

    public AsaasClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        ;
    }

    public async Task<TResponse> PostAsync<TResponse>(string endpoint, object payload,
        CancellationToken cancellationToken)
    {
        StringContent content = GetContent(payload);
        HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        TResponse responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);

        return responseContent!;
    }

    public async Task PostAsync(string endpoint, object payload, CancellationToken cancellationToken)
    {
        StringContent content = GetContent(payload);
        HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task<TResponse> PutAsync<TResponse>(string endpoint, object payload,
        CancellationToken cancellationToken)
    {
        StringContent content = GetContent(payload);
        HttpResponseMessage response = await _httpClient.PutAsync(endpoint, content, cancellationToken);

        response.EnsureSuccessStatusCode();

        TResponse responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        return responseContent!;
    }

    public async Task PutAsync(string endpoint, object payload, CancellationToken cancellationToken)
    {
        StringContent content = GetContent(payload);
        HttpResponseMessage response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task PatchAsync(string endpoint, object payload, CancellationToken cancellationToken)
    {
        StringContent content = GetContent(payload);
        HttpResponseMessage response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task<TResponse> PatchAsync<TResponse>(string endpoint, object payload,
        CancellationToken cancellationToken)
    {
        StringContent content = GetContent(payload);
        HttpResponseMessage response = await _httpClient.PatchAsync(endpoint, content, cancellationToken);

        response.EnsureSuccessStatusCode();

        TResponse responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        return responseContent!;
    }

    public async Task<TResponse> DeleteAsync<TResponse>(string endpoint, CancellationToken cancellationToken)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync(endpoint, cancellationToken);

        response.EnsureSuccessStatusCode();

        TResponse responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        return responseContent!;
    }

    public async Task DeleteAsync(string endpoint, CancellationToken cancellationToken)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync(endpoint, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<TResponse> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(endpoint, cancellationToken);

        response.EnsureSuccessStatusCode();

        TResponse responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);

        return responseContent!;
    }

    private StringContent GetContent(object payload)
    {
        return new StringContent(JsonSerializer.Serialize(payload, SerializerOptions),
            Encoding.UTF8,
            MediaTypeNames.Application.Json);
    }

    private static async Task<TResponse> ReadResponseContent<TResponse>(HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        string content = await response.Content.ReadAsStringAsync(cancellationToken);


        return JsonSerializer.Deserialize<TResponse>(content, SerializerOptions);
    }
}