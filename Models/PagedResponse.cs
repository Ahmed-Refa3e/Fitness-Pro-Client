namespace Fitness_Pro_Client.Models
{
    public class PagedResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public List<Gym> Data { get; set; } = [];

    }
}
