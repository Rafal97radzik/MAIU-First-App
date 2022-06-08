using Katsumi.Extensions;
using Katsumi.Pages;
using Katsumi.ViewModels;

namespace Katsumi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureServices(services =>
            {
				services.AddTransient<MainPage>();
				services.AddTransient<MainViewModel>();
            });

		return builder.Build();
	}
}
