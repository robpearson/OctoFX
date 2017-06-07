using System.Collections.Generic;
using System.Web.Mvc;
using NHibernate;
using OctoFX.Core.Model;

namespace OctoFX.TradingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var rate1 = new ExchangeRate(new CurrencyPair(Currency.Aud, Currency.Usd), 0.9301M);
            var rate2 = new ExchangeRate(new CurrencyPair(Currency.Gbp, Currency.Usd), 2.1001M);

            var rates = new List<ExchangeRate> {rate1, rate2};

            return View(rates);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
