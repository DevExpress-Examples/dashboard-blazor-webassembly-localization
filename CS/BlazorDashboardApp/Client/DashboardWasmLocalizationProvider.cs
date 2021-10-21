using DevExpress.DashboardWeb;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorDashboardApp.Client {
    public class DashboardWasmLocalizationProvider : IDashboardLocalizationProvider {
        IServiceProvider serviceProvider;
        Func<IEnumerable<string>> getJsonsListDelegate;

        public DashboardWasmLocalizationProvider(IServiceProvider serviceProvider, Func<IEnumerable<string>> getJsonsListDelegate) {
            this.serviceProvider = serviceProvider;
            this.getJsonsListDelegate = getJsonsListDelegate;
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
                HttpClient httpClient = scope.ServiceProvider.GetService<HttpClient>();
                var jsons = await Task.WhenAll(getJsonsListDelegate().Select(fileName => ReadFileAsync(httpClient, fileName)));
                return jsons.SelectMany(dict => dict).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            }
        }
    }
}
