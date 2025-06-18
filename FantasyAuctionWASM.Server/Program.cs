// FantasyAuctionWASM.Server/Program.cs
using FantasyAuctionWASM.Server.Hubs;
using FantasyAuctionWASM.Server.Services; // For AuctionService, PlayerService, BidderService
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Use if you have API controllers and Razor Pages/Views for hosting
builder.Services.AddRazorPages(); // Necessary if the Blazor app is hosted from a Razor Page (e.g., _Host.cshtml or similar)

// Register server-side application services
builder.Services.AddSingleton<AuctionService>();
builder.Services.AddSingleton<PlayerService>();
builder.Services.AddSingleton<BidderService>();

// Add SignalR services
builder.Services.AddSignalR();

// Configure response compression for SignalR
builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});

// Add CORS (Cross-Origin Resource Sharing) policy
// Adjust origins based on where your client app will be running during development and production.
// For a standard ASP.NET Core hosted Blazor WASM, the client is served from the same origin as the server,
// so CORS might not be strictly necessary for same-origin requests but is good for flexibility (e.g. if client is temporarily on different port).
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        // Example: Allow client running on typical development ports
        // For production, you'd restrict this to your actual client domain(s).
        policy.WithOrigins("http://localhost:5000", "https://localhost:5001", "http://localhost:5100", "https://localhost:5101") // Common WASM dev ports
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error"); // Make sure you have an Error.cshtml or appropriate handler
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

// Use CORS policy - must be called before UseRouting and UseEndpoints (or MapHub/MapControllers)
app.UseCors("CorsPolicy");

app.UseResponseCompression(); // Add response compression to the pipeline

// Serve static files from the Client project's wwwroot (e.g., index.html, css, js)
// UseBlazorFrameworkFiles must come before UseStaticFiles
app.UseBlazorFrameworkFiles(); // Serves framework files like blazor.webassembly.js
app.UseStaticFiles();          // Serves other static files from wwwroot of the Server project AND from wwwroot of Client project (if configured)

app.UseRouting();

// Map API controllers (if any)
app.MapControllers();

// Map SignalR Hub
app.MapHub<AuctionHub>("/auctionhub");

// Map Razor Pages (e.g., for _Host.cshtml or other Razor Pages in the Server project)
app.MapRazorPages();

// Fallback mapping for Blazor WASM. This ensures that client-side routes are handled by loading index.html.
app.MapFallbackToFile("index.html");

app.Run();
