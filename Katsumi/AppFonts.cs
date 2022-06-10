using Katsumi.Helpers.AppBuilding;

namespace Katsumi;

public class AppFonts : IFontConfigurator
{
    public void ConfigureFonts(IFontCollection fontCollection)
    {
        fontCollection.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fontCollection.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    }
}