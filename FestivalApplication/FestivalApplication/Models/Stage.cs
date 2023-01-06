using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Stage
    {
        [Key]
        public int StageId { get; set; }

        [Required]
        public string Naam { get; set; }
        public ICollection<ArtiestDatum> ArtiestDatums { get; set; }
    }
}
