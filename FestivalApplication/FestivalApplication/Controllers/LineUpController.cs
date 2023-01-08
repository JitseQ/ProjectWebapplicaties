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
    public class LineUpController : Controller
    {
        public IActionResult Index()
        {
            
            LineUpListViewModel viewModel = new LineUpListViewModel();
            viewModel.Artiesten = _context.Artiesten.ToList();
            return View(viewModel);
            
        }

        public IActionResult Details(int? id)
        {
            ArtiestDatum ad = _context.ArtiestDatums.Include(y => y.Artiest).Where(x => x.ArtiestId == id).FirstOrDefault();
            List<Artiest> artiesten = _context.Artiesten.Where(x => x.ArtiestId == id).ToList();
            if (ad != null)
            {
                LineUpDetailsViewModel viewModel = new LineUpDetailsViewModel()
                {
                    ArtiestId = ad.ArtiestId,
                    Beginuur = ad.Beginuur,
                    Einduur = ad.Einduur,
                    Datum = ad.Datum,
                    StageId = ad.StageId,
                    Artiesten = artiesten
                };
                return View(viewModel);
            }
            else
            {
                LineUpListViewModel viewModel = new LineUpListViewModel
                {
                    ArtiestDatums = _context.ArtiestDatums.ToList()
                };
                return View(viewModel);
            }
        }

        private readonly FestivalContext _context;

        public LineUpController(FestivalContext context)
        {
            _context = context;
        }
    }
}
