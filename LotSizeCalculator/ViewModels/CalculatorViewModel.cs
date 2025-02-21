/*
    The Calculator View Model controls the Calculator view
*/



using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using LotSizeCalculator.Models;

namespace LotSizeCalculator.ViewModels;

public partial class CalculatorViewModel : ObservableObject
{

    public ObservableCollection<Currency> Currencies { get; set; } = [];

    [ObservableProperty]
    Currency selectedCurrency;

    public CalculatorViewModel()
    {
        InitCurrencies();
        // selectedCurrency = new();

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
}