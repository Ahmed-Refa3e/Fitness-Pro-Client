namespace Fitness_Pro_Client.Models
{
    public class GymDetailsDto
    {
        public int GymID { get; set; }
        public string GymName { get; set; }
        public string? PictureUrl { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Governorate { get; set; }

        public decimal MonthlyPrice { get; set; }
        public decimal YearlyPrice { get; set; }
        public decimal FortnightlyPrice { get; set; }
        public decimal SessionPrice { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public string CoachID { get; set; }
        public string CoachFullName { get; set; }
        public string? CoachProfilePictureUrl { get; set; }

        public int AverageRating { get; set; }
        public int SubscriptionsCount { get; set; }
    }
}
