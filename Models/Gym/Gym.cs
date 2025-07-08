namespace Fitness_Pro_Client.Models.Gym
{
    public class Gym
    {
        public int GymID { get; set; }
        public string GymName { get; set; } = string.Empty;
        public string PictureUrl { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Governorate { get; set; } = string.Empty; 
        public decimal MonthlyPrice { get; set; }
        public double AverageRating { get; set; }
        public int SubscriptionsCount { get; set; }
    }
}
