using System.Collections.Generic;

namespace DeckOfCards.Models
{
    /// <summary>
    /// File : IDeckService
    /// Autor: Khurram Shahzad
    /// Purpose:Service manages and return Deck view model
    ///
    /// History:
    /// 16-Jun-2020: Created
    /// </summary>
    public class Deck : IDeck
    {
        #region public methods

        public IList<ICard> Cards { get; set; }

        #endregion public methods

        #region constructor

        public Deck()
        {
            // initializing variables
            Cards = new List<ICard>();

            // creates 52 cards with respetive Suit 13 cards each
            for (byte i = 2; i <= 14; i++)
            {
                Cards.Add(new Card(i, enumCardSuit.Club));
                Cards.Add(new Card(i, enumCardSuit.Diamond));
                Cards.Add(new Card(i, enumCardSuit.Heart));
                Cards.Add(new Card(i, enumCardSuit.Spade));
            }
        }

        #endregion constructor
    }
}