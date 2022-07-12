using BlazorDashboardApp.Server;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using Microsoft.Extensions.FileProviders;

namespace BlazorDashboardApp {
    public static class DashboardUtils {
        public static DashboardConfigurator CreateDashboardConfigurator(IConfiguration configuration, IFileProvider fileProvider) {
            DashboardConfigurator configurator = new DashboardConfigurator();

            // Register Dashboard Storage
            configurator.SetDashboardStorage(new DashboardFileStorage(fileProvider.GetFileInfo("App_Data/Dashboards").PhysicalPath));

            // Create a sample data source
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            DashboardObjectDataSource objectDataSource = new DashboardObjectDataSource("Object Data Source") { DataId = "employees" };
            configurator.DataLoading += (s, e) => {
                if (e.DataId == "employees") {
                    e.Data = Employee.Employees;
                }
            };

            configurator.SetDataSourceStorage(dataSourceStorage);

            return configurator;
        }

    }
}