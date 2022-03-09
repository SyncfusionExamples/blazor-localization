using LocalizationServerApp.Data;
using LocalizationServerApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkwNTAyQDMxMzkyZTM0MmUzMGduMExrNHJITk4xOEZ4Z1RXTDkxU29FMkhUdVVyeXhEd1pKZHE5R1ZPUW89");
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddControllers();
// Set the resx file folder path to access
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
// Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

var app = builder.Build();
app.UseRequestLocalization("de");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
