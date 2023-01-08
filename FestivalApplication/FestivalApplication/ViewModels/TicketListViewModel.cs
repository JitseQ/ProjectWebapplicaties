using FestivalApplication.Models;
using System.Collections.Generic;

namespace FestivalApplication.ViewModels
{
    public class TicketListViewModel
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }

        public int Prijs { get; set; }

        public string Beschrijving { get; set; }

        public List<Product> Producten { get; set; }
    }
}
