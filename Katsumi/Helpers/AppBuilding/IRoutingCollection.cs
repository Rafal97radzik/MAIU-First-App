namespace Katsumi.Helpers.AppBuilding
{
    public interface IRoutingCollection
    {
        void RegisterRoute(string route, RouteFactory factory);

        void RegisterRoute(string route, Type type);
    }
}
