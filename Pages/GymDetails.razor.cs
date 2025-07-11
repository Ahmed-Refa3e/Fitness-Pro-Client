namespace Fitness_Pro_Client.Pages
{
    public partial class GymDetails
    {
        [Parameter] public int id { get; set; }

        private GymDetailsDto? gym;

        protected override async Task OnInitializedAsync()
        {
            gym = await GymService.GetGymByIdAsync(id);
        }
    }
}