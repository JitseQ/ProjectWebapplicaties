using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class ArtiestGenre
    {
        [Key]
        public int ArtiestGenreId { get; set; }

        [Required]
        public int ArtiestId { get; set; }

        [Required]
        public int GenreId { get; set; }


        public Genre Genre { get; set; }
        public Artiest Artiest { get; set; }
    }
}
