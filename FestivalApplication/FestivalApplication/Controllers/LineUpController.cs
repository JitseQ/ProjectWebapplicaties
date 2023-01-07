using FestivalApplication.Data;
using Microsoft.AspNetCore.Mvc;
using FestivalApplication.ViewModels;
using System.Linq;

namespace FestivalApplication.Controllers
{
    public class LineUpController : Controller
    {
        public IActionResult Index()
        {
            LineUpListViewModel viewModel = new LineUpListViewModel();
            viewModel.ArtiestDatums = _context.ArtiestDatums.ToList();
            //viewModel.Artiesten = _context.Artiesten.ToList();
            return View(viewModel);
        }

        private readonly FestivalContext _context;

        public LineUpController(FestivalContext context)
        {
            _context = context;
        }
    }
}
