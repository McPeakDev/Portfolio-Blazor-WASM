using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using portfolio;
using MudBlazor.Services;
using BlazorTransitionableRoute;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<BlazorTransitionableRoute.IRouteTransitionInvoker, DefaultRouteTransitionInvoker>();
builder.Services.AddMudServices();


await builder.Build().RunAsync();
