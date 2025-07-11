namespace Fitness_Pro_Client.Services;

public class LocationService(HttpClient httpClient)
{
    private const string JsonFilePath = "data/locations.json";
    private Dictionary<string, List<string>> _locations = [];

    private bool _isLoaded = false;

    private async Task EnsureLocationsLoadedAsync()
    {
        if (_isLoaded) return;

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(JsonFilePath);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            Dictionary<string, List<string>>? result = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            _locations = result ?? [];
            _isLoaded = true;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Failed to load locations: {ex.Message}");
            _locations = [];
        }
    }

    public async Task<List<string>> GetGovernoratesAsync()
    {
        await EnsureLocationsLoadedAsync();
        return [.. _locations.Keys.OrderBy(g => g)];
    }

    public async Task<List<string>> GetCitiesAsync(string governorate)
    {
        await EnsureLocationsLoadedAsync();

        return _locations.TryGetValue(governorate, out List<string>? cities)
            ? [.. cities.OrderBy(c => c)]
            : [];
    }
}
