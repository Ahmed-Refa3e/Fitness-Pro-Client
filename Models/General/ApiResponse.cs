namespace Fitness_Pro_Client.Models.General
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
    }
}