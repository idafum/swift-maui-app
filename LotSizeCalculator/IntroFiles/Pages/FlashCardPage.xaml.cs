/*
    The code behind the FlashCardPage
*/
using LotSizeCalculator.IntroFiles.ViewModels;

namespace LotSizeCalculator.IntroFiles.Pages;

partial class FlashCardPage : ContentPage
{
    public FlashCardPage()
    {
        InitializeComponent();
        BindingContext = new FlashCardViewModel();
    }

    void OnStartClicked(object sender, EventArgs args)
    {
        if (Application.Current != null)
        {
            //Navigate to the app shell
            Application.Current.Windows[0].Page = new AppShell();

            Preferences.Set("HasSeenIntro", true);
        }
    }
}