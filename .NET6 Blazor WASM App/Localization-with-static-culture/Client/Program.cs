using LocalizationWASMApp.Client;
using LocalizationWASMApp.Client.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using System.Globalization;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkxMjc2QDMxMzkyZTM0MmUzMGduMExrNHJITk4xOEZ4Z1RXTDkxU29FMkhUdVVyeXhEd1pKZHE5R1ZPUW89");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
await builder.Build().RunAsync();
