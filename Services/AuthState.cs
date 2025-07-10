using Blazored.LocalStorage;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Fitness_Pro_Client.Services
{
    public class AuthState(ILocalStorageService localStorage)
    {
        public async Task<bool> IsLoggedInAsync()
        {
            string? token = await localStorage.GetItemAsStringAsync("token");
            token = token?.Trim('"');

            return !string.IsNullOrWhiteSpace(token) && !IsTokenExpired(token);
        }

        public async Task<string?> GetUserRoleAsync()
        {
            string? token = await localStorage.GetItemAsStringAsync("token");
            token = token?.Trim('"');

            if (string.IsNullOrWhiteSpace(token)) return null;

            try
            {
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwt = handler.ReadJwtToken(token);

                Claim? roleClaim = jwt.Claims.FirstOrDefault(c =>
                    c.Type == ClaimTypes.Role || c.Type == "role" || c.Type.Contains("claims/role"));

                return roleClaim?.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error parsing token: {ex.Message}");
                return null;
            }
        }

        private static bool IsTokenExpired(string token)
        {
            token = token?.Trim('"')!;

            if (string.IsNullOrWhiteSpace(token) || token.Count(c => c == '.') != 2)
            {
                Console.WriteLine("⚠️ Invalid JWT format.");
                return true;
            }

            try
            {
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwt = handler.ReadJwtToken(token);
                return jwt.ValidTo < DateTime.UtcNow;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to read JWT: {ex.Message}");
                return true;
            }
        }
    }
}
