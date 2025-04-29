/*
    The code behing the Calculator Page
*/

using LotSizeCalculator.ShellAppFiles.ViewModels;

namespace LotSizeCalculator.ShellAppFiles.Pages;

public partial class CalculatorPage : ContentPage
{
    public CalculatorPage(CalculatorViewModel calculatorViewModel)
    {
        InitializeComponent();
        BindingContext = calculatorViewModel;

        //Default Currency selected always USD
        currencyPicker.SelectedIndex = 0;
    }
}