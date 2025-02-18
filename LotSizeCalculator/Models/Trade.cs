/*
    A Trade Object represents the data object used for Lot Size Calculation
*/
namespace LotSizeCalculator.Models;

public class Trade
{
    //A trading Pair. This would be or type enum. 
    public string Pair { get; set; } = string.Empty;

    //A trade type
    public string Type { get; set; } = string.Empty;

    //Market Price
    public double MarketPrice { get; set; }

    //Account Balance
    public double AccountBalance { get; set; }

    //Risk Percentage
    public double RiskPercentage { get; set; }

    //Stop Loss In Pips
    public int StopLossInPips { get; set; }

    //Default Constructor
    public Trade() { }
}