using Microsoft.AspNetCore.Mvc;

namespace CarbuneApacks.Controllers
{
    public class WebsiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DespreNoi()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult CarbuneLemn()
        {
            return View("carbuni-lemn");
        }

        public IActionResult ReviewuriCarbuniLemn()
        {
            return View("reviewuri-carbuni-lemn");
        }

        [HttpPost]
        public IActionResult TrimiteContact(string nume, string email, string mesaj)
        {
            TempData["Succes"] = "Mesajul tău a fost trimis cu succes!";
            return RedirectToAction("Contact");
        }

        [Route("produse")]
        public IActionResult Produse()
        {
            return View("produse");
        }

        public IActionResult CumAlegiCarbunii()
        {
            return View("cum-alegi-carbunii");
        }

        // Pagini produse SEO
        public IActionResult CarbuniHexagonaliBrichetati()
        {
            return View("carbuni-hexagonali-brichetati");
        }

        public IActionResult CarbuniRumegus()
        {
            return View("carbuni-rumegus");
        }

        [Route("produse/carbuni-cocos")]
        public IActionResult CarbuniCocos()
        {
            return View("carbuni-cocos");
        }

        [Route("reviewuri/carbuni-cocos")]
        public IActionResult ReviewCocos()
        {
            return View("review-cocos");
        }

        public IActionResult CarbuniBambus()
        {
            return View("carbuni-bambus");
        }

        public IActionResult KitLemneAprindere()
        {
            return View("kit-lemne-aprindere");
        }

        public IActionResult LanaLemn()
        {
            return View("lana-lemn");
        }

        public IActionResult AprinzatorCarbuniOtel()
        {
            return View("aprinzator-carbuni-otel");
        }

        public IActionResult ClesteOtel()
        {
            return View("cleste-otel");
        }

        public IActionResult PerieGratar()
        {
            return View("perie-gratar");
        }
    }
}
