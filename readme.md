<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/419774191/21.2.2%2B)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for Blazor WebAssembly - Localization

The example shows how to localize the Dashboard component in Blazor WebAssembly applications:

- Translate UI element captions to a different language: dialog boxes, buttons, menu items, error messages, and so on (localization).
- Format numbers, dates, and currencies according to specific culture settings (globalization).

The app uses **JSON strings** to localize the Dashboard component. 

A custom [CultureSelector](./CS/BlazorDashboardApp/Client/Components/CultureSelector.razor) UI component is implemented to allow users to change the culture at runtime. The app saves the current culture in a cookie that can be read by the Dashboard Localization Provider.

![blazor-localized-dashboard](img/blazor-localized-dashboard.png)

<!-- default file list -->
## Files to Look At

* [Dashboard.razor](./CS/BlazorDashboardApp/Client/Pages/Dashboard.razor)
* [CultureSelector.razor](./CS/BlazorDashboardApp/Client/Components/CultureSelector.razor)
* [index.html](./CS/BlazorDashboardApp/Client/wwwroot/index.html#L18-L27)
* [Program.cs](./CS/BlazorDashboardApp/Client/Program.cs)
* [DashboardWasmLocalizationProvider.cs](./CS/BlazorDashboardApp/Client/DashboardWasmLocalizationProvider.cs)
<!-- default file list end -->

## Documentation

- [Create a Blazor WebAssembly Dashboard Application](https://docs.devexpress.com/Dashboard/401892?v=21.1)

## More Examples

- [Get Started - Dashboard Component in Blazor Server Application](https://github.com/DevExpress-Examples/dashboard-blazor-server-app)
- [Dashboard Blazor WebAssembly App - Configuration](https://github.com/DevExpress-Examples/dashboard-blazor-webassembly-configuration)
- [Dashboard Blazor WebAssembly App - JavaScript Customization](https://github.com/DevExpress-Examples/dashboard-blazor-webassembly-js-customization)
