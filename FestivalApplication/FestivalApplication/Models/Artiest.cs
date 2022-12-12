using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Artiest
    {
        [Key]
        public int ArtiestId { get; set; }

        [NotNull]
        public string Naam { get; set; }

        public string Beschrijving { get; set; }

        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Spotify { get; set; }
    }
}
