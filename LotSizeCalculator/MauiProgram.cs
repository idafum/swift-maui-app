using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace LotSizeCalculator;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

			//MPLUSRounded1c Fonts
			fonts.AddFont("MPLUSRounded1c-Black.ttf", "Black");
			fonts.AddFont("MPLUSRounded1c-ExtraBold.ttf", "ExtraBold");
			fonts.AddFont("MPLUSRounded1c-Bold.ttf", "Bold");
			fonts.AddFont("MPLUSRounded1c-Medium.ttf", "Medium");
			fonts.AddFont("MPLUSRounded1c-Regular.ttf", "Regular");
			fonts.AddFont("MPLUSRounded1c-Light.ttf", "Light");
			fonts.AddFont("MPLUSRounded1c-Thin.ttf", "Thin");
		}).UseMauiCommunityToolkit();
#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}