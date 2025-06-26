using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase.Client;
using EventEase.Services; // Import custom service namespace

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root App component
builder.RootComponents.Add<App>("#app");

// Register the HeadOutlet component (for dynamic <head> content like title/meta)
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register a scoped HttpClient service for making API calls
builder.Services.AddScoped(sp => new HttpClient 
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

// Register a singleton service to manage user session state across pages
builder.Services.AddSingleton<SessionState>();

// If you plan to inject AttendanceService in future, register it here:
// builder.Services.AddSingleton<AttendanceService>();

await builder.Build().RunAsync();
