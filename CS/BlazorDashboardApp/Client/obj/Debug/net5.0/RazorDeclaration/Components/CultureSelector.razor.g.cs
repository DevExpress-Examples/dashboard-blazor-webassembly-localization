// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDashboardApp.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using BlazorDashboardApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using BlazorDashboardApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using DevExpress.DashboardBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\_Imports.razor"
using DevExpress.DashboardWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\Components\CultureSelector.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\Components\CultureSelector.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class CultureSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\work\examples\localization-blazor\dashboard-blazor-webassembly-app\CS\BlazorDashboardApp\Client\Components\CultureSelector.razor"
       

    CultureInfo[] supportedCultures = new[] {
        new CultureInfo("en-US"),
        new CultureInfo("de-DE"),
    };
    CultureInfo[] supportedUICultures = new[] {
        new CultureInfo("en-US"),
        new CultureInfo("de-DE"),
    };

    protected override void OnInitialized() {
        Culture = Thread.CurrentThread.CurrentCulture;
        UICulture = Thread.CurrentThread.CurrentUICulture;
    }

    CultureInfo Culture {
        get => Thread.CurrentThread.CurrentCulture;
        set {
            if (Thread.CurrentThread.CurrentCulture != value)
                ChangeCulture("blazorCulture.set", value);
        }
    }

    CultureInfo UICulture {
        get => Thread.CurrentThread.CurrentUICulture;
        set {
            if (Thread.CurrentThread.CurrentUICulture != value)
                ChangeCulture("blazorUICulture.set", value);
        }
    }

    void ChangeCulture(string clientMethod, CultureInfo culture) {
        ((IJSInProcessRuntime)JSRuntime).InvokeVoid(clientMethod, culture.Name);
        Nav.NavigateTo(Nav.Uri, forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
