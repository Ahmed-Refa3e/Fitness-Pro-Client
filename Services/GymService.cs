using Fitness_Pro_Client.Models;
using System.Net.Http.Json;

namespace Fitness_Pro_Client.Services
{
    public class GymService(HttpClient http)
    {
        public async Task<PagedGymResponse?> GetGymsAsync(int page = 1, int pageSize = 9, string? GymName = null, string? governorate = null, string? city = null)
        {
            var query = $"?pageNumber={page}&pageSize={pageSize}";

            if (!string.IsNullOrWhiteSpace(GymName))
                query += $"&GymName={Uri.EscapeDataString(GymName)}";

            if (!string.IsNullOrWhiteSpace(governorate))
                query += $"&governorate={Uri.EscapeDataString(governorate)}";

            if (!string.IsNullOrWhiteSpace(city))
                query += $"&city={Uri.EscapeDataString(city)}";

            return await http.GetFromJsonAsync<PagedGymResponse>($"api/Gym{query}")!;
        }

        public async Task<GymDetailsDto?> GetGymByIdAsync(int id)
        {
            return await http.GetFromJsonAsync<GymDetailsDto>($"api/Gym/{id}");
        }
    }
}
