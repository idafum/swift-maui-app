/*
	The App Class

	- It derives from the application class making it the root of the Risk2 app.
	- The MauiAppBuilder uses this as the specified app. 
*/
using System.Diagnostics;

namespace LotSizeCalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//For Development testing
		//Preferences.Remove("HasSeenIntro");
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		bool hasSeenIntro = Preferences.Get("HasSeenIntro", false);

		if (hasSeenIntro)
		{
			return new Window(new AppShell());
		}
		else
		{
			Debug.WriteLine("User has not seen Intro: Displaying now..");
			return new Window();
		}
	}
}