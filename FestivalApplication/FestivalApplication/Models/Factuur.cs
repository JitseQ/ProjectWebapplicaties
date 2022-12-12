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

        [NotNull]
        public ICollection<Gebruiker> GebruikerId { get; set; }

        [NotNull]
        public DateTime Datum { get; set; }

    }
}
