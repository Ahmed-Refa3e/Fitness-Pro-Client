namespace Fitness_Pro_Client.Helpers;

public class CustomAuthorizationMessageHandler(ILocalStorageService localStorage) : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        string? token = await localStorage.GetItemAsStringAsync("token");

        if (!string.IsNullOrWhiteSpace(token))
        {
            token = token.Trim('"');
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
