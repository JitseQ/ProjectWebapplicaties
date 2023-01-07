using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Gebruiker
    {

        [Key]
        public int GebruikerId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Voornaam { get; set; }

        [Required]
        public string Gebruikersnaam { get; set; }

        [Required]
        public DateTime Geboortedatum { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Telefoonnummer { get; set; }

        [Required]
        public string Straatnaam { get; set; }

        [Required]
        public int Huisnummer { get; set; }

        [Required]
        public int Postcode { get; set; }

        [Required]
        public string Dorp { get; set; }

        [Required]
        public Boolean IsAdmin { get; set; }


        public ICollection<Factuur> Facturen { get; set; }
    }
}
