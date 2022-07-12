using DevExpress.DashboardWeb;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorDashboardApp.Client {
    public class DashboardWasmLocalizationProvider : IDashboardLocalizationProvider {
        static string[] GetJsonList() {
            switch (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName) {
                case "de":
                    return new string[] {
                            "./localization/de/dx-dashboard.de.json",
                            "./localization/de/dx-analytics-core.de.json"
                    };
                default:
                    return new string[] { };
            }
        }

        IServiceProvider serviceProvider;

        public DashboardWasmLocalizationProvider(IServiceProvider serviceProvider) {
            this.serviceProvider = serviceProvider;
        }
        

        async Task<Dictionary<string, string>> ReadFileAsync(HttpClient httpClient, string fileName) {
            var httpRes = await httpClient.GetAsync(fileName);
            if (httpRes.StatusCode == HttpStatusCode.NotFound) {
                return new Dictionary<string, string>();
            }
            var response = await httpRes.Content.ReadAsByteArrayAsync();
            return JsonSerializer.Deserialize<Dictionary<string, string>>(response);
        }

        public async Task<Dictionary<string, string>> GetLocalizationMessagesAsync() {
            using (IServiceScope scope = serviceProvider.CreateScope()) {
                HttpClient? httpClient = scope.ServiceProvider.GetService<HttpClient>();
                var jsons = await Task.WhenAll(GetJsonList().Select(fileName => ReadFileAsync(httpClient, fileName)));
                return jsons.SelectMany(dict => dict).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            }
        }
    }
}
