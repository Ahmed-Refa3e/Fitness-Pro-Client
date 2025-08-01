﻿namespace Fitness_Pro_Client.Models.OnlineTraining
{
    public class Coach
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
        public string? Bio { get; set; }
        public string Gender { get; set; } = string.Empty;
        public DateTime JoinedDate { get; set; }
        public Double Rating { get; set; }
    }

}