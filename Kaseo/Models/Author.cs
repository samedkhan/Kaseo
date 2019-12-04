using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kaseo.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        
        public List<AuthorSocialLink> SocialLinks { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}