using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class AuthorSocialLink
    {
        [Key]
        public int SocialLinkId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(150)]
        public string Url { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}