using System.Collections.Generic;

namespace DeckOfCards.ViewModels
{
    public interface IDeckViewModel
    {
        IEnumerable<ICardViewModel> CardList { get; set; }
    }
}