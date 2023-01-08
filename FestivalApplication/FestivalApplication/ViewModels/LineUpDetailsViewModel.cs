using System.ComponentModel.DataAnnotations;
using System;
using FestivalApplication.Models;
using System.Collections.Generic;

namespace FestivalApplication.ViewModels
{
    public class LineUpDetailsViewModel
    {
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

        public List<Artiest> Artiesten { get; internal set; }
        public List<Stage> Stages { get; internal set; }

    }
}
