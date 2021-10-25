using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorDashboardApp.Client {
    public class Program {
        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IDashboardLocalizationProvider>(sp => new DashboardWasmLocalizationProvider(sp));

            var host = builder.Build();
            var js = host.Services.GetRequiredService<IJSRuntime>();

            CultureInfo culture;
            string savedCulture = null;
            savedCulture = await js.InvokeAsync<string>("blazorCulture.get");
            if(savedCulture != null) {
                culture = new CultureInfo(savedCulture);
            } else {
                culture = new CultureInfo("en-US");
                await js.InvokeVoidAsync("blazorCulture.set", "en-US");
            }
            CultureInfo.DefaultThreadCurrentCulture = culture;

            CultureInfo uiCulture;
            string savedUICulture = null;
            savedUICulture = await js.InvokeAsync<string>("blazorUICulture.get");
            if(savedUICulture != null) {
                uiCulture = new CultureInfo(savedUICulture);
            } else {
                uiCulture = new CultureInfo("en-US");
                await js.InvokeVoidAsync("blazorUICulture.set", "en-US");
            }
            CultureInfo.DefaultThreadCurrentUICulture = uiCulture;

            await host.RunAsync();
        }
    }
}
