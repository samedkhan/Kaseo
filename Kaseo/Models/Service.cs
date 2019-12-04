using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [MaxLength(150)]
        [Required]
        public string Title { get; set; }

        [MaxLength(150)]
        [Required]
        public string TitleSlug { get; set; }

        [MaxLength(150)]
        [Required]
        public string Desc { get; set; }

        [MaxLength(100)]
        [Required]
        public string Icon { get; set; }

        [Required]
        public int OrderBy { get; set; }

        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string ContentText { get; set; }


    }
}