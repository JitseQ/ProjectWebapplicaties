using FestivalApplication.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FestivalApplication.ViewModels
{
    public class MerchandiseListViewModel
    {
       
        public int ProductId { get; set; }
        public string Naam { get; set; }

        public int Prijs { get; set; }

        public string Beschrijving { get; set; }

        public int ArtiestId { get; set; }

        public List<Artiest> Artiesten { get; set; }
        public List<Product> Producten { get; set; }
    }
}
