namespace DeckOfCards.Models
{
    public interface ICard
    {
        enumCardSuit CardSuit { get; set; }
        byte CardValue { get; set; }
    }
}