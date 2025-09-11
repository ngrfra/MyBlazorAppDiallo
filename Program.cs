using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorAppDiallo;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
/* 
 * This code sets up a Blazor WebAssembly application.
 * It configures the root components and registers an HttpClient service
 * with a base address derived from the host environment.
 * Finally, it builds and runs the application asynchronously.
 */