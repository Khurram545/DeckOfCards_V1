namespace DeckOfCards.Models
{
    public class Card : CardBase, ICard
    {
        /// <summary>
        /// constructor with initializing properties
        /// </summary>
        /// <param name="cardValue"></param>
        /// <param name="cardSuit"></param>
        public Card(byte cardValue, enumCardSuit cardSuit)
        {
            this.CardValue = cardValue;
            this.CardSuit = cardSuit;
        }
    }
}