namespace Fitness_Pro_Client.Models
{
    public class Gym
    {
        public int GymID { get; set; }
        public string GymName { get; set; }
        public string PictureUrl { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Governorate { get; set; }
        public decimal MonthlyPrice { get; set; }
        public double AverageRating { get; set; }
        public int SubscriptionsCount { get; set; }
    }
}
