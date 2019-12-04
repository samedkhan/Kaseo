using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kaseo.Models
{
    public class Setting
    {
        public int SettingId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fax { get; set; }

        [Required]
        [MaxLength(50)]
        public string  Photo { get; set; }
         

        [MaxLength(50)]
        public string FooterLogo { get; set; }


        [MaxLength(100)]
        public string FooterText { get; set; }
    }
}