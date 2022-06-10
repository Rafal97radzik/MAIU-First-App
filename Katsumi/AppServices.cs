using Katsumi.Helpers.AppBuilding;
using Katsumi.Pages;
using Katsumi.ViewModels;

namespace Katsumi
{
    public class AppServices: IServiceConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainPage>();
            services.AddTransient<MainViewModel>();

            services.AddTransient<ProductListPage>();
            services.AddTransient<ProductListViewModel>();

            services.AddTransient<SurprisePage>();
        }
    }
}
