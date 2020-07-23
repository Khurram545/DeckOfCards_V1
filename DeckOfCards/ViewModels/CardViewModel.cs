using DeckOfCards.Models;

namespace DeckOfCards.ViewModels
{
    public class CardViewModel : ICardViewModel
    {
        //
        // Summary:
        //     Gets or sets the text of the selected item.
        //
        // Returns:
        //     The text.
        public string Text { get; set; }

        //
        // Summary:
        //     Gets or sets the value of the selected item.
        //
        // Returns:
        //     The value.
        public int CardValue { get; set; }

        public string Value { get; set; }

        /// <summary>
        /// Get or Sets Card suit
        /// </summary>
        public enumCardSuit CardSuit { get; set; }

        /// <summary>
        /// Card Weight calculated for Cards Greater than 10
        /// this shows Special Cards at top
        /// </summary>
        public int CardSuitWeight
        {
            get
            {
                var cardSuitValue = (int)this.CardSuit;
                return this.CardValue > 10 ? 100 + cardSuitValue : 0 + cardSuitValue;
            }
        }

        /// <summary>
        /// Readonly property after converting special cards to display Value
        /// e.g. Card 14 displays Ace
        /// </summary>
        public string CardDisplayValue
        {
            get
            {
                var returnValue = CardValue.ToString();
                // convert special card value to respective chars
                // e.g. 14  = Ace
                switch (this.CardValue)
                {
                    case SharedConstants.CardValue_King:
                        returnValue = SharedConstants.CardValueDiplay_King;
                        break;

                    case SharedConstants.CardValue_Queen:
                        returnValue = SharedConstants.CardValueDiplay_Queen;
                        break;

                    case SharedConstants.CardValue_Jack:
                        returnValue = SharedConstants.CardValueDiplay_Jack;
                        break;

                    case SharedConstants.CardValue_Ace:
                        returnValue = SharedConstants.CardValueDiplay_Ace;
                        break;
                }
                return returnValue;
            }
        }

        /// <summary>
        /// Calculate Card ranks to show highest cards in UI
        /// </summary>
        public int CardDisplayRank
        {
            get
            {
                var cardWeight = CardSuitWeight;
                // combines card weight and value to show order by rank
                return cardWeight + this.CardValue;
            }
        }

        /// <summary>
        /// read only property Calculate and return display text as special char
        /// </summary>
        public string CardDisplayText
        {
            get
            {
                // Gets card Icon based on suit
                var suitIcon = SharedConstants.DimondIcon;
                switch (this.CardSuit)
                {
                    case enumCardSuit.Club:
                        suitIcon = SharedConstants.ClubIcon;
                        break;

                    case enumCardSuit.Heart:
                        suitIcon = SharedConstants.HeartIcon;
                        break;

                    case enumCardSuit.Spade:
                        suitIcon = SharedConstants.SpadeIcon;
                        break;
                }

                // set icon and value in given format
                return string.Format(SharedConstants.CardDisplayFormat, suitIcon, CardDisplayValue);
            }
        }
    }
}