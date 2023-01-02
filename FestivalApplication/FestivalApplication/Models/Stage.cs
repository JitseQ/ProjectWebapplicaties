using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Stage
    {
        [Key]
        public int StageId { get; set; }

        [NotNull]
        public string Naam { get; set; }

    }
}
