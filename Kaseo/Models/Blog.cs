using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string TitleSlug { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string ContentText { get; set; }

        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author  Author { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogcategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }

    }
}