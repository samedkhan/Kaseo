using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Kaseo.Models;

namespace Kaseo.Data
{
    public class KaseoContext:DbContext
    {
        public KaseoContext() : base("KaseoContext")
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorSocialLink> AuthorSocialLinks { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategorys { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategorys { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }

    }
}