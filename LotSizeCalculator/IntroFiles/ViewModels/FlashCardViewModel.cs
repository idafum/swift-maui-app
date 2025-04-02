/*
    FlashcardsViewModel

    This viewmodel controls the flashcards view
*/
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using LotSizeCalculator.IntroFiles.Models;

namespace LotSizeCalculator.IntroFiles.ViewModels;

partial class FlashCardViewModel : ObservableObject
{
    public ObservableCollection<FlashCard> FlashCards { get; set; } = [];
    public FlashCardViewModel()
    {
        Populator();
    }

    /// <summary>
    /// Populator
    /// 
    /// Populates the Obserservable Collection of FlashCards Models
    /// </summary>
    private void Populator()
    {
        FlashCards.Add(new FlashCard("risk_dots.png", "You don't need to trade everything!", "Start with EUR/USD, GBP/USD, or AUD/USD – master just one"));
        FlashCards.Add(new FlashCard("risk_alert.png", "Risk is everything!", "Risk kills more trades than bad calls"));
        FlashCards.Add(new FlashCard("risk_calculator.png", "Know your lot size before every trade!", "Sizing is the difference between surviving and blowing up"));
        FlashCards.Add(new FlashCard("risk_calculator_logo.png", "Risk2 helps you trade smarter!", "A simple Lot Size Calculator"));
    }
}