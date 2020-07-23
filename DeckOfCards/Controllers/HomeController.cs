using DeckOfCards.Service;
using System.Web.Mvc;

namespace DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        private IDeckService _deckService;

        public HomeController()
        {
            _deckService = new DeckService();
        }

        public ActionResult Index()
        {
            var vmDeck = _deckService.Get();
            return View(vmDeck);
        }

    }
}