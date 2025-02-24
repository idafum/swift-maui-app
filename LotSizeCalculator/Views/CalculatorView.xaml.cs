
/*
    This is the Page behind the CalculatorView.xaml. 
*/
using System.Diagnostics;
using System.Globalization;
using CoreMotion;
using LotSizeCalculator.Models;
using LotSizeCalculator.ViewModels;

namespace LotSizeCalculator.Views;

public partial class CalculatorView : ContentPage
{
    readonly CalculatorViewModel vm;
    public CalculatorView()
    {
        InitializeComponent();
        vm = new CalculatorViewModel();
        BindingContext = vm;

        //Default Currency selected always USD
        currencyPicker.SelectedIndex = 0;

    }

}