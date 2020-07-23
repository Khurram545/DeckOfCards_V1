using DeckOfCards.ViewModels;

namespace DeckOfCards.Service
{
    public interface IDeckService
    {
        /// <summary>
        /// Returns Deck viewmodel
        /// </summary>
        /// <returns></returns>
        DeckViewModel Get();
    }
}