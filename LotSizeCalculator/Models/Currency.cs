/*
    A currency model represents a Trading currency. 
*/
namespace LotSizeCalculator.Models;

public class Currency
{
    public string Code { get; set; } = string.Empty;
    public string Flag { get; set; } = string.Empty;

    //Default Constructor
    public Currency() { }
}