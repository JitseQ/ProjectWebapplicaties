﻿using Microsoft.AspNetCore.Mvc;

namespace FestivalApplication.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
