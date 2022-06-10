using Katsumi.Helpers.AppBuilding;
using Katsumi.Pages;

namespace Katsumi;

public class AppRouting: IRoutingConfigurator
{
    public void ConfigureRouting(IRoutingCollection routingCollection)
    {
        routingCollection.RegisterRoute("mainPage", typeof(MainPage));
        routingCollection.RegisterRoute("mainPage/productList", typeof(ProductListPage));
        routingCollection.RegisterRoute("mainPage/productList/surprise", typeof(SurprisePage));
    }
}