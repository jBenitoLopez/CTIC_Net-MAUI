using Microsoft.Extensions.Logging;

namespace _3_5__ciclo_de_vida;

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
				fonts.AddFont("Anstting Kishon.ttf", "AnsttingKishon");

            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
