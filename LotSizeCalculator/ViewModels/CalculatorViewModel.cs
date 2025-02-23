/*
    The Calculator View Model controls the Calculator view
*/

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LotSizeCalculator.Models;

namespace LotSizeCalculator.ViewModels;

public partial class CalculatorViewModel : ObservableObject
{

    public ObservableCollection<Currency> Currencies { get; set; } = [];

    [ObservableProperty]
    Currency selectedCurrency;

    [ObservableProperty]
    double accountBalance;

    [ObservableProperty]
    string formattedBalance = "";

    [ObservableProperty]
    double risk;

    [ObservableProperty]
    double stopLossInPips;

    public CalculatorViewModel()
    {
        InitCurrencies();
        SelectedCurrency = new();
    }

    public void InitCurrencies()
    {
        Currencies.Add(new Currency { Code = "USD", Flag = "usd.png" });
        Currencies.Add(new Currency { Code = "CAD", Flag = "cad.png" });
        Currencies.Add(new Currency { Code = "GBP", Flag = "gbp.png" });
        Currencies.Add(new Currency { Code = "AUD", Flag = "aud.png" });
        Currencies.Add(new Currency { Code = "JPY", Flag = "jpy.png" });
        Currencies.Add(new Currency { Code = "CHF", Flag = "chf.png" });
    }

    // partial void OnSelectedCurrencyChanged(Currency? oldValue, Currency newValue)
    // {
    //     Debug.WriteLine($"Currency has changed to {newValue.Code}");

    //     if (newValue != null)
    //     {
    //         CultureInfo oldCulture;
    //         if (oldValue != null)
    //         {
    //             oldCulture = oldValue.GetCulture();
    //             Debug.WriteLine($"Old Culture: {oldCulture}");
    //         }

    //         CultureInfo newCulture = newValue.GetCulture();

    //         Debug.WriteLine($"New Culture: {newCulture}");

    //         if (double.TryParse(FormattedBalance, NumberStyles.Currency, oldCulture, out double amount))
    //     }
    // }

    partial void OnSelectedCurrencyChanged(Currency? oldValue, Currency newValue)
    {
        if (newValue != null && oldValue != null)
        {
            var oldCulture = oldValue.GetCulture();
            var newCulture = newValue.GetCulture();

            if (double.TryParse(FormattedBalance, NumberStyles.Currency, oldCulture, out double amount))
            {
                AccountBalance = amount;
                FormattedBalance = amount.ToString("C", newCulture);
            }
        }
    }
}