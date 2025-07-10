using Blazored.LocalStorage;
using Fitness_Pro_Client;
using Fitness_Pro_Client.Helpers;
using Fitness_Pro_Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<CustomAuthorizationMessageHandler>();

builder.Services.AddHttpClient("AuthorizedClient", client =>
{
    client.BaseAddress = new Uri("https://fitnesspro.runasp.net/");
})
.AddHttpMessageHandler<CustomAuthorizationMessageHandler>();


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://fitnesspro.runasp.net/")
});

builder.Services.AddScoped(sp =>
{
    IHttpClientFactory factory = sp.GetRequiredService<IHttpClientFactory>();
    return new GymService(factory.CreateClient("AuthorizedClient"));
});

builder.Services.AddScoped(sp =>
{
    IHttpClientFactory factory = sp.GetRequiredService<IHttpClientFactory>();
    return new CoachService(factory.CreateClient("AuthorizedClient"));
});

builder.Services.AddScoped(sp =>
{
    IHttpClientFactory factory = sp.GetRequiredService<IHttpClientFactory>();
    return new AuthService(factory.CreateClient("AuthorizedClient"));
});

builder.Services.AddScoped(sp =>
{
    IHttpClientFactory factory = sp.GetRequiredService<IHttpClientFactory>();
    return new PaymentService(factory.CreateClient("AuthorizedClient"));
});

builder.Services.AddScoped<LocationService>();

builder.Services.AddScoped<AuthState>();

await builder.Build().RunAsync();
