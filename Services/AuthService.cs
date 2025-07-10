using Fitness_Pro_Client.Models.Account;
using System.Net.Http.Json;

namespace Fitness_Pro_Client.Services
{
    public class AuthService(HttpClient http)
    {
        public async Task<bool> RegisterCoachAsync(RegisterModel model)
        {
            HttpResponseMessage response = await http.PostAsJsonAsync("api/Account/RegisterCoach", model);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RegisterTraineeAsync(RegisterModel model)
        {
            HttpResponseMessage response = await http.PostAsJsonAsync("api/Account/RegisterTrainee", model);
            return response.IsSuccessStatusCode;
        }
        public async Task<LoginResponse?> LoginAsync(LoginRequest loginRequest)
        {
            HttpResponseMessage response = await http.PostAsJsonAsync("api/Account/Login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                LoginResponse? result = await response.Content.ReadFromJsonAsync<LoginResponse>();
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

            HttpResponseMessage response = await http.PostAsJsonAsync("api/Account/confirmemail", payload);

            if (response.IsSuccessStatusCode)
                return (true, null);

            string error = await response.Content.ReadAsStringAsync();
            return (false, error);
        }
    }
}
