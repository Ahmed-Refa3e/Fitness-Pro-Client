﻿using Fitness_Pro_Client.Models.General;
using Fitness_Pro_Client.Models.OnlineTraining;
using System.Net.Http.Json;

namespace Fitness_Pro_Client.Services
{
    public class CoachService(HttpClient http)
    {
        public async Task<PagedCoachResponse?> GetCoachesAsync(int page = 1, int pageSize = 9, string? CoachName = null,
            double? MinRating = null, double? MaxRating = null, string? SortBy = null)
        {
            string query = $"?pageNumber={page}&pageSize={pageSize}";

            if (MinRating.HasValue)
                query += $"&MinRating={MinRating.Value}";

            if (MaxRating.HasValue)
                query += $"&MaxRating={MaxRating.Value}";

            if (!string.IsNullOrWhiteSpace(CoachName))
                query += $"&CoachName={Uri.EscapeDataString(CoachName)}";

            if (!string.IsNullOrWhiteSpace(SortBy))
                query += $"&SortBy={Uri.EscapeDataString(SortBy)}";

            return await http.GetFromJsonAsync<PagedCoachResponse>($"api/User/GetAllCoaches{query}")!;
        }

        public async Task<ApiResponse<CoachDetailsDto>?> GetCoachByIdAsync(string id)
        {
            return await http.GetFromJsonAsync<ApiResponse<CoachDetailsDto>>($"api/User/CoachDetails/{id}");
        }

        public async Task<List<OnlineTrainingDto>?> GetGroupOnlineTrainingByCoachIdAsync(string id)
        {
            return await http.GetFromJsonAsync<List<OnlineTrainingDto>>($"api/OnlineTraining/ByCoachId/Group?CoachId={id}");
        }
        public async Task<List<OnlineTrainingDto>?> GetPrivateOnlineTrainingByCoachIdAsync(string id)
        {
            return await http.GetFromJsonAsync<List<OnlineTrainingDto>>($"api/OnlineTraining/ByCoachId/Private?CoachId={id}");
        }
    }
}
