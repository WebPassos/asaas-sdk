using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WP.Asaas.Sdk.Commons;

internal class AsaasClient : IAsaasClient
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = 
        { 
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
            new FlexibleDateTimeConverter(),
            new FlexibleNullableDateTimeConverter()
        }
    };

    private readonly HttpClient _httpClient;

    public AsaasClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TResponse> PostAsync<TResponse>(string endpoint, object payload,
        CancellationToken cancellationToken)
    {
        var content = GetContent(payload);
        var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
        
        // Log detalhado para debug
        Console.WriteLine($"[DEBUG] POST Request:");
        Console.WriteLine($"  Endpoint: {endpoint}");
        Console.WriteLine($"  Status Code: {(int)response.StatusCode} ({response.StatusCode})");
        Console.WriteLine($"  Request URL: {response.RequestMessage?.RequestUri}");
        
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync(cancellationToken);
            Console.WriteLine($"[ERROR] Response Content: {errorContent}");
            Console.WriteLine($"[ERROR] Response Headers:");
            foreach (var header in response.Headers)
            {
                Console.WriteLine($"  {header.Key}: {string.Join(", ", header.Value)}");
            }
            
            throw new HttpRequestException(
                $"Response status code does not indicate success: {(int)response.StatusCode} ({response.StatusCode}). " +
                $"Endpoint: {endpoint}. " +
                $"Full URL: {response.RequestMessage?.RequestUri}. " +
                $"Response: {errorContent}");
        }
        
        var responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        Console.WriteLine($"[SUCCESS] Response received successfully");
        return responseContent;
    }

    public async Task PostAsync(string endpoint, object payload, CancellationToken cancellationToken)
    {
        var content = GetContent(payload);
        var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task<TResponse> PutAsync<TResponse>(string endpoint, object payload,
        CancellationToken cancellationToken)
    {
        var content = GetContent(payload);
        var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        return responseContent!;
    }

    public async Task PutAsync(string endpoint, object payload, CancellationToken cancellationToken)
    {
        var content = GetContent(payload);
        var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
        
    }

    public async Task PatchAsync(string endpoint, object payload, CancellationToken cancellationToken)
    {
        var content = GetContent(payload);
        var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task<TResponse> PatchAsync<TResponse>(string endpoint, object payload,
        CancellationToken cancellationToken)
    {
        var content = GetContent(payload);
        var response = await _httpClient.PatchAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        return responseContent!;
    }

    public async Task<TResponse> DeleteAsync<TResponse>(string endpoint, CancellationToken cancellationToken)
    {
        var response = await _httpClient.DeleteAsync(endpoint, cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);
        return responseContent!;
    }

    public async Task DeleteAsync(string endpoint, CancellationToken cancellationToken)
    {
        var response = await _httpClient.DeleteAsync(endpoint, cancellationToken);
        response.EnsureSuccessStatusCode();
    }

    public async Task<TResponse> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync(endpoint, cancellationToken);
        
        response.EnsureSuccessStatusCode();
        
        var responseContent = await ReadResponseContent<TResponse>(response, cancellationToken);

        return responseContent!;
    }

    private StringContent GetContent(object payload)
    {
        var json = JsonSerializer.Serialize(payload, SerializerOptions);
        Console.WriteLine($"[DEBUG] JSON Payload: {json}");
        return new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json);
    }

    private static async Task<TResponse> ReadResponseContent<TResponse>(HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<TResponse>(content, SerializerOptions);
    }
}