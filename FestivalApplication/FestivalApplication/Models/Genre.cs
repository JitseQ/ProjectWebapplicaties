using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        public string Naam { get; set; }

        public ICollection<ArtiestGenre> ArtiestGenres { get; set; }
    }
}
