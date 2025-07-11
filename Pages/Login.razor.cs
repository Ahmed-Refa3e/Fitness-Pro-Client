namespace Fitness_Pro_Client.Pages
{
    public partial class Login
    {
        private readonly LoginRequest LoginRequest = new();
        private string? errorMessage;

        private async Task HandleLogin()
        {
            errorMessage = null;

            LoginResponse? result = await AuthService.LoginAsync(LoginRequest);

            if (result is not null && result.IsSuccess && result.Data is not null)
            {
                await localStorage.SetItemAsync("token", result.Data.Token);
                await localStorage.SetItemAsync("refreshToken", result.Data.RefreshToken);
                await localStorage.SetItemAsync("expiresAt", result.Data.Exipiration);

                Navigation.NavigateTo("/", forceLoad: true);
            }
            else
            {
                errorMessage = "? Login failed. Please check your credentials.";
            }
        }
    }
}