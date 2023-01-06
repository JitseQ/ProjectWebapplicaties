using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public int Prijs { get; set; }
       
        [Required]
        public string Beschrijving { get; set; }

        public int ArtiestId { get; set; }
        
        // Relatie connectiviteit tegengestelde pool
        public Artiest Artiest { get; set; }

        public ICollection<FactuurProduct> FactuurProducten { get; set; }
    }
}
