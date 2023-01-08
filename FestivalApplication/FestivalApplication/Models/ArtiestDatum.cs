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

        [Required]
        public int ArtiestId { get; set; }

        [Required]
        public int StageId { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        [Required]
        public string Beginuur { get; set; }

        [Required]
        public string Einduur { get; set; }


        public virtual Artiest Artiest { get; set; }
        public Stage Stage { get; set; }
    }
}
