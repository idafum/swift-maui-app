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
    ObservableCollection<FlashCard> FlashCards { get; set; } = [];
    public FlashCardViewModel()
    {

    }
    private void Populator()
    {
        FlashCards.Add(new FlashCard("risk-intro1.png", "You don't need to trade everything!", "Start with EUR/USD, GBP/USD, or AUD/USD – master just one"));
    }
}