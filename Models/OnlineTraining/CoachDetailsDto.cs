﻿namespace Fitness_Pro_Client.Models.OnlineTraining
{
    public class CoachDetailsDto
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
        public string? Bio { get; set; }
        public string Gender { get; set; } = string.Empty;
        public double? Rating { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
