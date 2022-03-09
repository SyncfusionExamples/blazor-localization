using LocalizationServer.Data;
using LocalizationServer.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using Syncfusion.Blazor;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkwNTAzQDMxMzkyZTM0MmUzMGduMExrNHJITk4xOEZ4Z1RXTDkxU29FMkhUdVVyeXhEd1pKZHE5R1ZPUW89");
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddControllers();
// Set the resx file folder path to access
//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
// Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
var supportedCultures = new[] { "en-US", "de", "fr", "ar", "zh" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);
var app = builder.Build();
app.UseRequestLocalization(localizationOptions);
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
