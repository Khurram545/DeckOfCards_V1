namespace DeckOfCards.Models
{
    /// <summary>
    /// Base Model Class for Card
    /// This class deal holds shared properties and logic of card
    /// </summary>
    public class CardBase : ICard
    {
        #region public properties
        public enumCardSuit CardSuit { get; set; }
        public byte CardValue { get; set; }
        #endregion
    }

}