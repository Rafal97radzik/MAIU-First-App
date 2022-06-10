using Katsumi.Helpers.AppBuilding;

namespace Katsumi.Helpers.Extensions;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder ConfigureServices<T>(this MauiAppBuilder mauiAppBuilder) where T :class, IServiceConfigurator, new()
    {
        var serviceConfigurator = new T();

        serviceConfigurator.ConfigureServices(mauiAppBuilder.Services);

        return mauiAppBuilder;
    }

    public static MauiAppBuilder ConfigureFonts<T>(this MauiAppBuilder mauiAppBuilder) where T : class, IFontConfigurator, new()
    {
        var fontConfigurator = new T();
        var configureDelegate = fontConfigurator.ConfigureFonts;

        mauiAppBuilder.ConfigureFonts(configureDelegate);

        return mauiAppBuilder;
    }

    public static MauiAppBuilder ConfigureRouting<T>(this MauiAppBuilder mauiAppBuilder) where T : class, IRoutingConfigurator, new()
    {
        var routingConfigurator = new T();

        routingConfigurator.ConfigureRouting(new RoutingCollection());

        return mauiAppBuilder;
    }
}
