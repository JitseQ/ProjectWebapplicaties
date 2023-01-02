using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class Gebruiker
    {

        [Key]
        public int GebruikerId { get; set; }

        [NotNull]
        public string Naam { get; set; }

        [NotNull]
        public string Voornaam { get; set; }

        [NotNull]
        public string Gebruikersnaam { get; set; }

        [NotNull]
        public DateTime Geboortedatum { get; set; }

        [NotNull]
        public string Email { get; set; }

        [NotNull]
        public int Telefoonnummer { get; set; }

        [NotNull]
        public int Huisnummer { get; set; }

        [NotNull]
        public int Postcode { get; set; }

        [NotNull]
        public string Dorp { get; set; }

        [NotNull]
        public Boolean IsAdmin { get; set; }

    }
}
