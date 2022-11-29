using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class LineUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
