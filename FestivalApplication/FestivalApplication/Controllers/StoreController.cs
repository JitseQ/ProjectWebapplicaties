using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
