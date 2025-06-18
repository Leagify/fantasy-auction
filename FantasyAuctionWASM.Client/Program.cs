// FantasyAuctionWASM.Client/Program.cs
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FantasyAuctionWASM.Client; // Assuming App.razor is here, or the root namespace for components

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Default Blazor WASM templates usually have the App component in the project's root namespace.
// If it's in FantasyAuctionWASM.Client.Layout or .Pages, this would need adjustment.
// builder.RootComponents.Add<App>("#app"); // Standard setup, likely already in the template's Program.cs
// builder.RootComponents.Add<HeadOutlet>("head::after"); // Standard setup

// Configure HttpClient to point to the server project's base address.
// This is crucial for an ASP.NET Core hosted Blazor WASM app.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// TODO: Add any client-side specific services here if needed in the future.
// For example, state management services or SignalR connection management services.

await builder.Build().RunAsync();
