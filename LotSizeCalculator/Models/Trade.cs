/*
    A Trade Object represents the data object used for Lot Size Calculation
*/
namespace LotSizeCalculator.Models;

public class Trade
{

    //TRADE DETAILS: Pair, Type, and MarketPrice  
    public string Pair { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public double MarketPrice { get; set; }

    //RISK MANAGEMENT: AccountBalance, Risk%, and StopLossInPips
    public double AccountBalance { get; set; }
    public double RiskPercentage { get; set; }
    public int StopLossInPips { get; set; }

    //Default Constructor
    public Trade() { }
}