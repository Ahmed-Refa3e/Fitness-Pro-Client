namespace Fitness_Pro_Client.Models
{
    public class CoachDetailsDto
    {
        public string Id { get; set; } 
        public string FullName { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
        public string? Bio { get; set; }
        public string Gender { get; set; } = string.Empty;
        public double? Rating { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
