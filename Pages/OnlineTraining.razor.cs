namespace Fitness_Pro_Client.Pages
{
    public partial class OnlineTraining
    {
        private PagedCoachResponse? coaches;

        private int currentPage = 1;
        private string? search;
        private double? minRating = null;
        private double? maxRating = null;

        protected override async Task OnInitializedAsync()
        {
            await LoadPage(currentPage);
        }

        private async Task ApplyFilters()
        {
            currentPage = 1;
            await LoadPage(currentPage);
        }

        private async Task LoadPage(int page)
        {
            currentPage = page;
            coaches = await coachService.GetCoachesAsync(
                page: page,
                pageSize: 9,
                CoachName: search,
                MinRating: minRating,
                MaxRating: maxRating
            );
        }
    }
}