namespace Fitness_Pro_Client.Models.Account
{
    public class LoginResponse
    {
        public bool IsSuccess { get; set; }
        public LoginData? Data { get; set; }
    }

    public class LoginData
    {
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime Exipiration { get; set; }
    }
}
