using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var result = Start();
            return View(result);
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

        private List<FizzResult> Start()
        {
            //any number divisible by three is replaced by the word fizz and any number divisible by five by
            //the word buzz. Numbers divisible by both three and five (i.e. divisible by 15) become fizz buzz. 

            List<FizzResult> results = new List<FizzResult>();

            for (int i = 1; i <= 100; i++)
            {
                int counter = i;
                results.Add(new FizzResult()
                {
                    Count = counter,
                    Word = i.ToString()
                });
            }

            return results;
        }
    }
}