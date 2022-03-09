using LocalizationWASMSample.Client.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LocalizationWASMSample.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkxMjc2QDMxMzkyZTM0MmUzMGduMExrNHJITk4xOEZ4Z1RXTDkxU29FMkhUdVVyeXhEd1pKZHE5R1ZPUW89");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
            // Register the Syncfusion locale service to customize the Blazor component locale culture
            builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("de");
            await builder.Build().RunAsync();
        }
    }
}
