using FantasyAuctionApp.Components;
using FantasyAuctionApp.Hubs; // Add this using statement
using FantasyAuctionApp.Services; // Add this using statement for services

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSignalR(); // <--- Add this line for SignalR services

builder.Services.AddSingleton<AuctionService>();
builder.Services.AddSingleton<PlayerService>();
builder.Services.AddSingleton<BidderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapHub<AuctionHub>("/auctionhub"); // <--- Add this line to map the hub

app.Run();
