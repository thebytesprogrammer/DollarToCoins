using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DollarToCoins.Models;

namespace DollarToCoins.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new DollarToCoinsViewModel();

            ViewBag.CoinOutput = new CoinsOutput();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DollarToCoinsViewModel model)
        {
            ViewBag.CoinOutput = new CoinsOutput();

            ViewBag.message = "";

            if (ModelState.IsValid && Decimal.TryParse(model.dollarAmount, out Decimal dollarAmount))
            {
                CoinsOutput coinsOutput = new DollarToCoinsCalculator(Decimal.Parse(model.dollarAmount)).coinsOutput;

                if (coinsOutput != null)
                {
                    ViewBag.CoinOutput = coinsOutput;
                }
            }
            else
            {
                ViewBag.message = "Error! Please check your input and try again.";
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
