namespace Fitness_Pro_Client.Pages;

public partial class Gyms
{
    private PagedGymResponse? gyms;

    private int currentPage = 1;

    private string? search;
    private string? selectedGovernorate;
    private string? selectedCity;

    private List<string> governorates = [];
    private List<string> cities = [];

    protected override async Task OnInitializedAsync()
    {
        await LoadPage(currentPage);
        governorates = await LocationService.GetGovernoratesAsync();
    }

    private async Task ApplyFilters()
    {
        currentPage = 1;
        await LoadPage(currentPage);
    }

    private async Task LoadPage(int page)
    {
        currentPage = page;
        gyms = await GymService.GetGymsAsync(
            page: page,
            pageSize: 9,
            GymName: search,
            governorate: selectedGovernorate,
            city: selectedCity
        );
    }

    private async Task OnGovernorateChanged(ChangeEventArgs e)
    {
        selectedGovernorate = e.Value?.ToString();
        cities = string.IsNullOrEmpty(selectedGovernorate)
            ? []
            : await LocationService.GetCitiesAsync(selectedGovernorate);
        selectedCity = null;
    }
}