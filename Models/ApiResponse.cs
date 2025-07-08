namespace Fitness_Pro_Client.Models
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
    }
}