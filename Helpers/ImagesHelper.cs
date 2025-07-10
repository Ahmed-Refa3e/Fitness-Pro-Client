namespace Fitness_Pro_Client.Helpers
{
    public static class ImagesHelper
    {
        public static string GetImageUrl(string? url) => string.IsNullOrWhiteSpace(url) ? "images/Default.png" : url;
    }
}
