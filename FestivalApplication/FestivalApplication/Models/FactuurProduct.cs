using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class FactuurProduct
    {
        [Key]
        public int FactuurProductId { get; set; }

        [Required]
        public int FactuurId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Aantal { get; set; }

        // Relatie connectiviteit tegengestelde pool
        public Factuur Factuur { get; set; }
        public Product Product { get; set; }

    }
}
