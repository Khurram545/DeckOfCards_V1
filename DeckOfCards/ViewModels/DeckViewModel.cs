using System.Collections.Generic;

namespace DeckOfCards.ViewModels
{
    public class DeckViewModel : IDeckViewModel
    {
        /// <summary>
        /// Returns available card List in Deck
        /// </summary>
        public IEnumerable<ICardViewModel> CardList { get; set; }
    }
}