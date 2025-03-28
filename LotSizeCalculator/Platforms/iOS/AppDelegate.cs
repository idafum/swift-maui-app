using Foundation;

namespace LotSizeCalculator;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	//IOS Platform makes a call to get the configured maui app.
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
