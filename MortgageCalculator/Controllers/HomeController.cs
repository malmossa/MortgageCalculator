using Microsoft.AspNetCore.Mvc;
using MortgageCalculator.Models;
using System.Diagnostics;

namespace MortgageCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult MortgagePage()      
        {
            Loan model = new Loan();

            model.Payment = 0;
            model.TotalInterest= 0;
            model.TotalCost= 0;
            model.Rate= 3.5M;
            model.Amount= 15000M;
            model.Term= 60;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MortgagePage(Loan loan)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}