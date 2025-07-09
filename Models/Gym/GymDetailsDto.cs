namespace Fitness_Pro_Client.Models.Gym
{
    public class GymDetailsDto
    {
        public int GymID { get; set; }
        public string GymName { get; set; } = string.Empty;
        public string? PictureUrl { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Governorate { get; set; } = string.Empty;

        public decimal MonthlyPrice { get; set; }
        public decimal YearlyPrice { get; set; }
        public decimal FortnightlyPrice { get; set; }
        public decimal SessionPrice { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string CoachID { get; set; } = string.Empty;
        public string CoachFullName { get; set; } = string.Empty;
        public string? CoachProfilePictureUrl { get; set; }

        public Double AverageRating { get; set; }
        public int SubscriptionsCount { get; set; }
    }
}
