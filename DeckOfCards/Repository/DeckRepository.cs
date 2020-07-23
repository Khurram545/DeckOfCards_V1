using DeckOfCards.Models;

namespace DeckOfCards.Repository
{
    /// <summary>
    /// gets deck objects from repository
    /// </summary>
    public class DeckRepository : IDeckRepository
    {
        public IDeck _deckofCards;

        public DeckRepository()
        {
            _deckofCards = new Deck();
        }

        public IDeck Get()
        {
            return _deckofCards;
        }
    }
}