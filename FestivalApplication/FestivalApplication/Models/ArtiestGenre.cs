using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class ArtiestGenre
    {
        [Key]
        public int ArtiestGenreId { get; set; }

        [NotNull]
        public ICollection<Artiest> ArtiestId { get; set; }

        [NotNull]
        public ICollection<Genre> GenreId { get; set; }

    }
}
