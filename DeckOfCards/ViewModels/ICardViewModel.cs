using DeckOfCards.Models;

namespace DeckOfCards.ViewModels
{
    public interface ICardViewModel
    {
        string Text { get; set; }
        string Value { get; set; }
        int CardValue { get; set; }
        enumCardSuit CardSuit { get; set; }
    }
}