using DeckOfCards.Models;

namespace DeckOfCards.Repository
{
    public interface IDeckRepository
    {
        IDeck Get();
    }
}