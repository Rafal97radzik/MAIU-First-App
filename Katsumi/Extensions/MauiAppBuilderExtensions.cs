namespace Katsumi.Extensions;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder ConfigureServices(this MauiAppBuilder mauiAppBuilder, Action<IServiceCollection> services)
    {
        services(mauiAppBuilder.Services);

        return mauiAppBuilder;
    }
}
