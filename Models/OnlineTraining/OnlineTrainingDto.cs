namespace Fitness_Pro_Client.Models.OnlineTraining
{
    public class OnlineTrainingDto
    {
        public int Id { get; set; }
        public string CoachID { get; set; } = null!;
        public string? Title { get; set; } 
        public string? Description { get; set; } 
        public string TrainingType { get; set; } = null!;
        public decimal Price { get; set; }
        public int NoOfSessionsPerWeek { get; set; }
        public int DurationOfSession { get; set; } // in minutes
    }
}
