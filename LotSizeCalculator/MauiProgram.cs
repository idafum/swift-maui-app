using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

using LotSizeCalculator.ShellAppFiles.Popups;
using LotSizeCalculator.ShellAppFiles.ViewModels;
using LotSizeCalculator.ShellAppFiles.Pages;

namespace LotSizeCalculator;
public static class MauiProgram
{
	/// <summary>
	/// CreateMauiApp
	/// 
	/// Use the MauiAppBuilder to configure and build an app
	/// </summary>
	/// <returns> A configured Maui App</returns>
	public static MauiApp CreateMauiApp()
	{
		//MauiAppBuilder Instance. 
		var mauiAppBuilder = MauiApp.CreateBuilder();

		//Use a specified "App". Configure the app fonts.
		mauiAppBuilder.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
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
			})

			.UseMauiCommunityToolkit();

		//Register the popup and view model with the builder
		mauiAppBuilder.Services.AddTransientPopup<LotSizeResultPopup, LotSizePopupViewModel>();
		mauiAppBuilder.Services.AddTransient<CalculatorViewModel>();
		mauiAppBuilder.Services.AddSingleton<CalculatorPage>();
#if DEBUG
		mauiAppBuilder.Logging.AddDebug();
#endif

		return mauiAppBuilder.Build();
	}
}