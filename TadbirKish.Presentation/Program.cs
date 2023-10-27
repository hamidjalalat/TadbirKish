using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TadbirKish.Presentation;
using TadbirKish.Presentation.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<CovergeService>();
builder.Services.AddScoped<CalculationCoverService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.RootComponents.Add<App>("#app");

await builder.Build().RunAsync();
