using Fitness_Pro_Client.Models;
using System.Net.Http.Json;

namespace Fitness_Pro_Client.Services
{
    public class AuthService(HttpClient http)
    {
        public async Task<bool> RegisterCoachAsync(RegisterModel model)
        {
            var response = await http.PostAsJsonAsync("api/Account/RegisterCoach", model);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RegisterTraineeAsync(RegisterModel model)
        {
            var response = await http.PostAsJsonAsync("api/Account/RegisterTrainee", model);
            return response.IsSuccessStatusCode;
        }
        public async Task<LoginResponse?> LoginAsync(LoginRequest loginRequest)
        {
            var response = await http.PostAsJsonAsync("api/Account/Login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                return result;
            }

            return null;
        }


        public async Task<(bool IsSuccess, string? ErrorMessage)> ConfirmEmailAsync(string email, string code)
        {
            var payload = new
            {
                email,
                verificationCode = code
            };

            var response = await http.PostAsJsonAsync("api/Account/confirmemail", payload);

            if (response.IsSuccessStatusCode)
                return (true, null);

            var error = await response.Content.ReadAsStringAsync();
            return (false, error);
        }
    }
}
