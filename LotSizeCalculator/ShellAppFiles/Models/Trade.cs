/*
    Trade Model

    Holds trade information
*/

namespace LotSizeCalculator.ShellAppFiles.Models;

public class Trade
{
    public Currency Currency { get; set; }
    public double AccountBalance { get; set; }
    public double Risk { get; set; }
    public double StopLoss { get; set; }
    public string Pair { get; set; }
    public TradeAction Action { get; set; }
    public Trade(Currency currency, double accountBalance, double risk, double stopLoss, string pair, TradeAction action)
    {
        Currency = currency;
        AccountBalance = accountBalance;
        Risk = risk;
        StopLoss = stopLoss;
        Pair = pair;
        Action = action;
    }
}