/*
    A currency model represents a Trading currency. 
*/
using System.Globalization;

namespace LotSizeCalculator.Models;

public class Currency
{
    public string Code { get; set; } = string.Empty;
    public string Flag { get; set; } = string.Empty;

    //Method to return cultureInfo based on currency code
    public CultureInfo GetCulture()
    {
        return Code switch
        {
            "USD" => new CultureInfo("en-US"), // United States Dollar
            "CAD" => new CultureInfo("en-CA"), // Canadian Dollar
            "GBP" => new CultureInfo("en-GB"), // British Pound
            "AUD" => new CultureInfo("en-AU"), // Australian Dollar
            "JPY" => new CultureInfo("ja-JP"), // Japanese Yen
            "CHF" => new CultureInfo("de-CH"), // Swiss Franc
            _ => CultureInfo.CurrentCulture    // Default to system culture
        };
    }

    //Default Constructor
    public Currency() { }
}