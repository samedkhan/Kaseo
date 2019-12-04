using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class About
    {
        public int AboutId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required, MaxLength(100)]
        public string TitleSlug { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Content { get; set; }


        [MaxLength(20)]
        public string ButtonText { get; set; }

        [MaxLength(200)]
        public string Url { get; set; }
    }
}