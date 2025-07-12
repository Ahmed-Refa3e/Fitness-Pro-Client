namespace Fitness_Pro_Client.Pages;

public partial class CoachDetails
{
    [Parameter]
    public string Id { get; set; } = null!;

    private ApiResponse<CoachDetailsDto>? Coach;
    private List<OnlineTrainingDto>? groupTrainings;
    private List<OnlineTrainingDto>? privateTrainings;
    private string selectedType = "Group";
    private string? errorMessage;

    protected override async Task OnInitializedAsync()
    {
        Coach = await CoachService.GetCoachByIdAsync(Id);
        groupTrainings = [];
        privateTrainings = [];

        List<OnlineTrainingDto>? group = await CoachService.GetGroupOnlineTrainingByCoachIdAsync(Id);
        if (group is not null)
            groupTrainings = group;

        List<OnlineTrainingDto>? privates = await CoachService.GetPrivateOnlineTrainingByCoachIdAsync(Id);
        if (privates is not null)
            privateTrainings = privates;
    }

    private IEnumerable<OnlineTrainingDto> CurrentTrainings =>
        selectedType == "Group" ? groupTrainings ?? [] : privateTrainings ?? [];

    private async Task HandleSubscription(int trainingId)
    {
        errorMessage = null;

        bool isLoggedIn = await AuthState.IsLoggedInAsync();
        string? role = await AuthState.GetUserRoleAsync();

        if (!isLoggedIn)
        {
            errorMessage = "?? You must be logged in to subscribe.";
            Navigation.NavigateTo("/login");
            return;
        }

        if (role != "Trainee")
        {
            errorMessage = "Only Trainee users can subscribe to training packages.";
            return;
        }

        string? paymentUrl = await PaymentService.CreatePaymentSessionAsync(trainingId);

        if (!string.IsNullOrWhiteSpace(paymentUrl))
        {
            Navigation.NavigateTo(paymentUrl, forceLoad: true);
        }
        else
        {
            errorMessage = "Failed to initiate payment session. Please try again later.";
        }
    }
}