
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

    //The Method
    // private void AccountBalanceEntryUnfocused(object sender, FocusEventArgs e)
    // {
    //     Debug.WriteLine("Unfocused");
    //     vm.OnSelectedCurrencyChanged();
    //     //Ensure sender is entry and try converting to double
    //     if (sender is Entry entry)
    //     {
    //         CultureInfo culture;
    //         Currency seletedCurrency = vm.SelectedCurrency;
    //         if (seletedCurrency != null)
    //         {
    //             culture = seletedCurrency.GetCulture();

    //             //If user input it a Number
    //             if (double.TryParse(entry.Text, out double amount))
    //             {
    //                 vm.AccountBalance = amount;
    //                 vm.FormattedBalance = amount.ToString("C", culture);
    //                 Debug.WriteLine($"Account Balance: {vm.AccountBalance}, Formatted Balance: {vm.FormattedBalance}");
    //             }

    //             if (double.TryParse(entry.Text, NumberStyles.Currency, culture, out double amount2))
    //             {
    //                 vm.AccountBalance = amount2;
    //                 vm.FormattedBalance = amount2.ToString("C", culture);
    //                 Debug.WriteLine($"Account Balance: {vm.AccountBalance}, Formatted Balance: {vm.FormattedBalance}");
    //             }
    //         }
    //     }
    //     else
    //     {
    //         //Display a popup. Please enter valid balance
    //     }
    // }

}