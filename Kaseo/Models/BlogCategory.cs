using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}