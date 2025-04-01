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
}