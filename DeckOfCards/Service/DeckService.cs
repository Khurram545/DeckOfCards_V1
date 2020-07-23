using DeckOfCards.Models;
using DeckOfCards.Repository;
using DeckOfCards.ViewModels;
using System.Collections.Generic;

namespace DeckOfCards.Service
{
    /// <summary>
    /// Service Manages Deck ViewModel driven from DeckRepistory
    /// </summary>
    public class DeckService : IDeckService
    {
        private DeckViewModel _deckViewModel;
        private IDeckRepository _deckRepository;

        public DeckService()
        {
            _deckRepository = new DeckRepository();
        }

        public DeckViewModel Get()
        {
            // get deck from repository
            var deckModel = _deckRepository.Get();
            _deckViewModel = new DeckViewModel();

            List<CardViewModel> lstCardViewModels = new List<CardViewModel>();

            foreach (ICard card in deckModel.Cards)
            {
                CardViewModel vmCard = GetViewModelFromModel(card);
                lstCardViewModels.Add(vmCard);
            }

            DeckViewModel viewModelDeck = new DeckViewModel();
            viewModelDeck.CardList = lstCardViewModels;

            // return Deck View Model
            return viewModelDeck;
        }

        private CardViewModel GetViewModelFromModel(ICard card)
        {
            var viewModel = new CardViewModel();
            viewModel.CardValue = card.CardValue;
            viewModel.CardSuit = card.CardSuit;

            viewModel.Value = viewModel.CardDisplayRank.ToString();
            viewModel.Text = viewModel.CardDisplayText;

            return viewModel;
        }
    }
}