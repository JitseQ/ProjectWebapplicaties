using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Factuur
    {
        [Key]
        public int FactuurId { get; set; }

        [Required]
        public int GebruikerId { get; set; }

        [Required]
        public DateTime Datum { get; set; }

       
        // Relatie connectiviteit tegengestelde pool
        public Gebruiker Gebruiker { get; set; }

        public ICollection<FactuurProduct> FactuurProducten { get; set; }

    }
}
