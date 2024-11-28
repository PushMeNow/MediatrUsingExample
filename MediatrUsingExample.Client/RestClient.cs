using System.Net.Http.Json;

namespace MediatrUsingExample.Client;

internal class RestClient
{
    private readonly HttpClient _httpClient;

    public RestClient(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000"); // here need receive base address to service
    }

    public Task<TResponse> Get<TResponse>(string uri)
    {
        return _httpClient.GetFromJsonAsync<TResponse>(uri)!;
    }

    public async Task<TResponse> Post<TRequest, TResponse>(string uri, TRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(uri, request);
        return (await response.Content.ReadFromJsonAsync<TResponse>())!;
    }

    // PUT and DELETE the same
}