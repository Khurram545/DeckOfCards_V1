using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public interface IDeck
    {
        IList<ICard> Cards { get; set; }
    }
}