using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaseo.Models
{
    public enum ProjectStatus {
        Ongoing,
        Completed
    }
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        public int OrderBy { get; set; }

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
        [MaxLength(100)]
        public string ClientName { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal ProjectValue { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public ProjectCategory Category { get; set; }

        [Required]
        public ProjectStatus Status { get; set; }

        [MaxLength(150)]
        public string ProjectUrl { get; set; }
    }
}