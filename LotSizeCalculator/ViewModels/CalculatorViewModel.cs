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
    public CalculatorViewModel()
    {
        InitCurrencies();
    }

    public void InitCurrencies()
    {
        Currencies.Add(new Currency { Code = "USD", Flag = "flags/usa.png" });
        Currencies.Add(new Currency { Code = "CAD", Flag = "flags/cad.png" });
        Currencies.Add(new Currency { Code = "GBP", Flag = "flags/gbp.png" });
        Currencies.Add(new Currency { Code = "AUD", Flag = "flags/aud.png" });
        Currencies.Add(new Currency { Code = "JPY", Flag = "flags/jpy.png" });
        Currencies.Add(new Currency { Code = "CHF", Flag = "flags/chf.png" });
    }
}