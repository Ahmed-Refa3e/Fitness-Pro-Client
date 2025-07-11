namespace Fitness_Pro_Client.Pages
{
    public partial class Register
    {
        private readonly RegisterModel registerModel = new()
        {
            Gender = "",
            Role = ""
        };
        private string? errorMessage;

        private async Task HandleRegister()
        {
            bool success = false;

            if (registerModel.Role == "Coach")
            {
                success = await AuthService.RegisterCoachAsync(registerModel);
            }
            else if (registerModel.Role == "Trainee")
            {
                success = await AuthService.RegisterTraineeAsync(registerModel);
            }

            if (success)
            {
                Navigation.NavigateTo($"/confirm-email?email={Uri.EscapeDataString(registerModel.Email!)}");
            }
            else
            {
                errorMessage = "Registration failed. This email is already taken, please choose another..";
            }
        }
    }
}