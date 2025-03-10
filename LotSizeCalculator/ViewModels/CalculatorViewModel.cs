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
    public ObservableCollection<string> Pairs { get; set; } = [];

    [ObservableProperty]
    Currency selectedCurrency; //This property should be initialized

    [ObservableProperty]
    string selectedPair = "";

    [ObservableProperty]
    double accountBalance;

    [ObservableProperty]
    string formattedBalance = "";

    [ObservableProperty]
    double risk;

    [ObservableProperty]
    double stopLossInPips;

    //Validation Flags for Image Display
    [ObservableProperty] private string acountBalanceValidationImage;
    [ObservableProperty] private string riskValidationImage;
    [ObservableProperty] private string stopLossValidationImage;
    [ObservableProperty] private string pairValidationImage;
    [ObservableProperty] private string tradeTypeValidationImage;

    public CalculatorViewModel()
    {
        InitCurrencies();
        InitPairs();
        SelectedCurrency = new();
    }

    /// <summary>
    /// Initialize the supported currencies and the flags
    /// </summary>
    public void InitCurrencies()
    {
        Currencies.Add(new Currency { Code = "USD", Flag = "usd.png" });
        Currencies.Add(new Currency { Code = "CAD", Flag = "cad.png" });
        Currencies.Add(new Currency { Code = "GBP", Flag = "gbp.png" });
        Currencies.Add(new Currency { Code = "AUD", Flag = "aud.png" });
        Currencies.Add(new Currency { Code = "JPY", Flag = "jpy.png" });
        Currencies.Add(new Currency { Code = "CHF", Flag = "chf.png" });
    }

    /// <summary>
    /// Initialize the supported pairs
    /// </summary>
    public void InitPairs()
    {
        Pairs.Add("EURUSD");
        Pairs.Add("GBPUSD");
        Pairs.Add("AUDUSD");
        Pairs.Add("NZDUSD");
    }

    /// <summary>
    /// Format the Balance when triggered by either the Unfocused Event of the Currency Change
    /// </summary>
    /// <param name="oldCulture">Optional parameter</param>
    [RelayCommand]
    private void FormatBalance(CultureInfo? oldCulture = null)
    {
        //If no balance was entered
        if (FormattedBalance.Trim() == "" || SelectedCurrency == null)
        {
            return;
        }
        CultureInfo parseCulture = oldCulture ?? SelectedCurrency.GetCulture(); //Use Old Culture if provided, otherwise use new culture
        CultureInfo newCulture = SelectedCurrency.GetCulture();

        //Try Parse
        if (double.TryParse(FormattedBalance, NumberStyles.Currency, parseCulture, out double amount) ||
            double.TryParse(FormattedBalance, NumberStyles.Number, CultureInfo.InvariantCulture, out amount))
        {
            AccountBalance = amount;
            FormattedBalance = amount.ToString("C", newCulture);
        }
        else
        {
            Debug.WriteLine("Error parsing account balance");
        }

    }

    [RelayCommand]
    private void CalculateLotSize()
    {


    }



    /// <summary>
    /// Execut the FormatBalanceCommand when currency is changed.
    /// </summary>
    /// <param name="oldValue"></param>
    /// <param name="newValue"></param>
    partial void OnSelectedCurrencyChanged(Currency? oldValue, Currency newValue)
    {
        if (newValue != null && oldValue != null)
            FormatBalanceCommand.Execute(oldValue.GetCulture());
    }
}