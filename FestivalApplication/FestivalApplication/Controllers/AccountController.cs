using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
