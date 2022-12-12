using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FestivalApplication.Models
{
    public class FactuurProduct
    {
        [Key]
        public int FactuurProductId { get; set; }

        [NotNull]
        public ICollection<Factuur> FactuurId { get; set; }

        [NotNull]
        public ICollection<Product> ProductId { get; set; }

        [NotNull]
        public int Aantal { get; set; }
    }
}
