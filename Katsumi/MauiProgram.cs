using Katsumi.Helpers.Extensions;

namespace Katsumi;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        return MauiApp
            .CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureServices<AppServices>()
            .ConfigureFonts<AppFonts>()
            .ConfigureRouting<AppRouting>()
            .Build();
    }
}
