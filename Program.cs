using Fitness_Pro_Client;
using Fitness_Pro_Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://fitnesspro.runasp.net/") });

builder.Services.AddScoped<GymService>();
builder.Services.AddScoped<LocationService>();
builder.Services.AddScoped<CoachService>();


await builder.Build().RunAsync();
