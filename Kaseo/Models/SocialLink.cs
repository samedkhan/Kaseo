using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class SocialLink
    {
        public int SocialLinkId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(150)]
        public string Url { get; set; }

        public int SettingId { get; set; }

        public Setting Setting { get; set; }
    }
}