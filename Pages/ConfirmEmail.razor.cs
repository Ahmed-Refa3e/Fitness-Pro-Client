namespace Fitness_Pro_Client.Pages
{
    public partial class ConfirmEmail
    {
        private readonly OtpModel otpModel = new();
        private string message = string.Empty;
        private string messageClass = string.Empty;
        private bool isSubmitting = false;

        protected override void OnInitialized()
        {
            Uri uri = Navigation.ToAbsoluteUri(Navigation.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            string? emailFromQuery = query.Get("email");

            if (!string.IsNullOrWhiteSpace(emailFromQuery))
            {
                otpModel.Email = emailFromQuery;
            }
        }

        private async Task OnSubmitAsync()
        {
            isSubmitting = true;
            message = string.Empty;

            var result = await AuthService.ConfirmEmailAsync(otpModel.Email!, otpModel.Code!);

            if (result.IsSuccess)
            {
                message = "? Email confirmed successfully!";
                messageClass = "alert-success";

                await Task.Delay(1500);
                Navigation.NavigateTo("/login");
            }
            else
            {
                message = $"? Something went wrong. Please try again later.";
                messageClass = "alert-danger";
            }

            isSubmitting = false;
        }

        private void ResendCode()
        {
            // TODO: Call backend to resend OTP
            message = "?? A new OTP has been sent.";
            messageClass = "alert-info";
        }
    }
}