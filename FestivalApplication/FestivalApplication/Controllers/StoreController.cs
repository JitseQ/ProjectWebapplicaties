using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tickets()
        {
            return View();
        }

        public IActionResult Merchandise()
        {
            return View();
        }
    }
}
