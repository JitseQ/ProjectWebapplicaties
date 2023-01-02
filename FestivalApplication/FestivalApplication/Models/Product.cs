using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [NotNull]
        public string Naam { get; set; }

        [NotNull]
        public int Prijs { get; set; }
       
        [NotNull]
        public string Beschrijving { get; set; }

        public ICollection<Artiest> ArtiestId { get; set; }
    }
}
