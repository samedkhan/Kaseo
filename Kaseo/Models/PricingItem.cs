using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kaseo.Models
{
    public class PricingItem
    {
        [Key]
        public int PricingItemId { get; set; }

        [Required]
        [MaxLength(10)]
        public string ItemName { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        
        public bool IsFavorite { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength(1000)]
        public string Inludes { get; set; }

    }
}