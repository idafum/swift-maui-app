
/*
    This is the Page behind the CalculatorView.xaml. 
*/
using System.Diagnostics;
using System.Globalization;
using LotSizeCalculator.Models;
using LotSizeCalculator.ViewModels;

namespace LotSizeCalculator.Views;

public partial class CalculatorView : ContentPage
{
    readonly CalculatorViewModel vm;
    public CalculatorView(CalculatorViewModel calculatorViewModel)
    {
        InitializeComponent();
        vm = calculatorViewModel;
        BindingContext = vm;

        //Default Currency selected always USD
        currencyPicker.SelectedIndex = 0;
    }

}