using System.Web.Mvc;
using Twitch.Net.Interfaces;

namespace Twitch.MVCFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITwitchStaticClient _staticClient;

        public HomeController(ITwitchStaticClient staticClient)
        {
            _staticClient = staticClient;
        }

        public ActionResult Index()
        {
            var channel = _staticClient.GetChannel("gibletto");
            return View(channel);
        }

    }
}
