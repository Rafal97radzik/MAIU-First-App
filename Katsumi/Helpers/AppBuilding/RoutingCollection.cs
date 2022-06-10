namespace Katsumi.Helpers.AppBuilding;

public class RoutingCollection : IRoutingCollection
{
    public void RegisterRoute(string route, RouteFactory factory)
    {
        Routing.RegisterRoute(route, factory);
    }

    public void RegisterRoute(string route, Type type)
    {
        Routing.RegisterRoute(route, type);
    }
}