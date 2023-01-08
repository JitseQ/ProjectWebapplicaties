using FestivalApplication.Models;
using System.Collections.Generic;

namespace FestivalApplication.ViewModels
{
    public class LineUpListViewModel
    {
        public int Id { get; set; }
        public List<Artiest> Artiesten { get; set; }
        public List<ArtiestDatum> ArtiestDatums { get; set; }

    }
}
