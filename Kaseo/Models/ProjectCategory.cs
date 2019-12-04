using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kaseo.Models
{
    public class ProjectCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }


        public List<Project> Projects { get; set; }
    }
}