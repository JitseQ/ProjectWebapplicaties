using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class ArtiestDatum 
    {
        [Key]
        public int ArtiestDatumId { get; set; }

        [NotNull]
        public ICollection<Artiest> ArtiestId { get; set; }

        [NotNull]
        public ICollection<Stage> StageId { get; set; }

        [NotNull]
        public DateTime Datum { get; set; }

        [NotNull]
        public string Beginuur { get; set; }

        [NotNull]
        public string Einduur { get; set; }
    }
}
