using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
