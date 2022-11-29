using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
