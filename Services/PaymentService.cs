using Fitness_Pro_Client.Models;
using System.Net.Http.Json;

namespace Fitness_Pro_Client.Services
{
    public class PaymentService(HttpClient http)
    {
        public async Task<string?> CreatePaymentSessionAsync(int trainingId)
        {
            var payload = new { onlineTrainingId = trainingId };

            var response = await http.PostAsJsonAsync("api/Payments/create-checkout-session", payload);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Payment failed: {error}");
                return null;
            }

            PaymentResponse? result = await response.Content.ReadFromJsonAsync<PaymentResponse>();
            return result?.Url;
        }
    }
}
