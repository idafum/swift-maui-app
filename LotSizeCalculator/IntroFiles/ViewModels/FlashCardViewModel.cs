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

    }
}