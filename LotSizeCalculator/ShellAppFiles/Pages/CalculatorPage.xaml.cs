/*
    The code behing the Calculator Page
*/

using LotSizeCalculator.ShellAppFiles.ViewModels;

namespace LotSizeCalculator.ShellAppFiles.Pages;

partial class CalculatorPage : ContentPage
{
    public CalculatorPage()
    {
        InitializeComponent();
        BindingContext = new CalculatorViewModel();

        //Default Currency selected always USD
        currencyPicker.SelectedIndex = 0;
    }
}