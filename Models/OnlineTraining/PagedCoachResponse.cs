namespace Fitness_Pro_Client.Models.OnlineTraining
{
    public class PagedCoachResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public List<Coach> Data { get; set; } = [];

    }
}
