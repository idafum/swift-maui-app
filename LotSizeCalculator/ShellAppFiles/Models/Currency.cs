/*
    Currency Model
    
    Holds informatio for the account trading currency.
*/

using System.Globalization;

namespace LotSizeCalculator.ShellAppFiles.Models;

public class Currency
{
    public string Code { get; set; } = string.Empty;
    public string Flag { get; set; } = string.Empty;

    /// <summary>
    /// GetCulture
    ///
    /// This get the CultureInfo of the currency Object
    /// </summary>
    /// <returns>A CultureInfo Object</returns>
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
    public Currency() { }

}