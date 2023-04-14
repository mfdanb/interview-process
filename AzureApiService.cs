public class AzureApiService
{
    readonly IMemoryCache _memoryCache;
    readonly HttpClient _authenticatedClient;

    public AzureApiService(IMemoryCache memoryCache)
    {
        _authenticatedClient = new HttpClient();
    }

    public async Task List<AzureResource> GetAzureResources()
    {
        var response = await _authenticatedClient.GetFromJsonAsync<List<AzureResource>>("https://...");

        return response;
    }

    async Task EnsureClientIsAuthenticated()
    {
        if (!_memoryCache.TryGetValue("azureAuthToken", out string authToken))
        {
            var token = await GetAuthToken();
            int validForInSeconds;

            try
            {
                validForInSeconds = int.Parse(token.ExpiresIn);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error happened")
                throw;
            }

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(validForInSeconds - 5));

            _memoryCache.Set("azureAuthToken", token.AccessToken, cacheEntryOptions);

            authToken = token.AccessToken;
        }

        _authenticatedClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
    }
}
