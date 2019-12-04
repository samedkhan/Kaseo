using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class Slide
    {
        public int SlideId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string TitleSlug { get; set; }

        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }

        [MaxLength(50)]
        public string ButtonText { get; set; }

        [MaxLength(200)]
        public string Url { get; set; }
    }
}