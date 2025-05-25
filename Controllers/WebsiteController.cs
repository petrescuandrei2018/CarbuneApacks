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

        [HttpPost]
        public IActionResult TrimiteContact(string nume, string email, string mesaj)
        {
            TempData["Succes"] = "Mesajul tău a fost trimis cu succes!";
            return RedirectToAction("Contact");
        }

        public IActionResult Produse()
        {
            return View();
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

        public IActionResult CarbuniCocos()
        {
            return View("carbuni-cocos");
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
