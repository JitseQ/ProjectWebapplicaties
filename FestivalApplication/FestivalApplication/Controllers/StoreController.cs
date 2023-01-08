using FestivalApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FestivalApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FestivalApplication.ViewModels;
using System.Linq;
using FestivalApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace FestivalApplication.Controllers
{

    public class StoreController : Controller
    {
        public StoreController(FestivalContext context)
        {
            _context = context;
        }

        private readonly FestivalContext _context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tickets()
        {
            TicketListViewModel viewModel = new TicketListViewModel();
            viewModel.Producten = _context.Producten.Where(p => p.Naam.Contains("ticket")).ToList();
            return View(viewModel);
        }

        public IActionResult Merchandise()
        {
            MerchandiseListViewModel viewModel = new MerchandiseListViewModel();
            viewModel.Producten = _context.Producten.Where(p => p.Naam.Contains("shirt")).Where(p => p.Naam.Contains("trui")).ToList();
            return View();
        }
    }
}
