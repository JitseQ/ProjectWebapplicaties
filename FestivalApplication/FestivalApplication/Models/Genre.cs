using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [NotNull]
        public string Naam { get; set; }

    }
}
