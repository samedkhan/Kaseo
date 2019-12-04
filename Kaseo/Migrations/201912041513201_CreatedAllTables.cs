namespace Kaseo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        TitleSlug = c.String(nullable: false, maxLength: 100),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        ButtonText = c.String(maxLength: 20),
                        Url = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Photo = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Title = c.String(nullable: false, maxLength: 150),
                        TitleSlug = c.String(nullable: false, maxLength: 150),
                        ContentText = c.String(nullable: false, storeType: "ntext"),
                        AuthorId = c.Int(nullable: false),
                        BlogcategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.BlogCategories", t => t.BlogcategoryId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.BlogcategoryId);
            
            CreateTable(
                "dbo.BlogCategories",
                c => new
                    {
                        BlogCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BlogCategoryId);
            
            CreateTable(
                "dbo.AuthorSocialLinks",
                c => new
                    {
                        SocialLinkId = c.Int(nullable: false, identity: true),
                        Icon = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 150),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialLinkId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.ProjectCategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        OrderBy = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 150),
                        TitleSlug = c.String(nullable: false, maxLength: 150),
                        ContentText = c.String(nullable: false, storeType: "ntext"),
                        ClientName = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        ProjectValue = c.Decimal(nullable: false, storeType: "money"),
                        CategoryId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        ProjectUrl = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.ProjectCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        TitleSlug = c.String(nullable: false, maxLength: 150),
                        Desc = c.String(nullable: false, maxLength: 150),
                        Icon = c.String(nullable: false, maxLength: 100),
                        OrderBy = c.Int(nullable: false),
                        Photo = c.String(nullable: false, maxLength: 100),
                        ContentText = c.String(nullable: false, storeType: "ntext"),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Fax = c.String(nullable: false, maxLength: 50),
                        Photo = c.String(nullable: false, maxLength: 50),
                        FooterLogo = c.String(maxLength: 50),
                        FooterText = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.SettingId);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        SlideId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        TitleSlug = c.String(nullable: false, maxLength: 150),
                        Desc = c.String(nullable: false, maxLength: 200),
                        ButtonText = c.String(maxLength: 50),
                        Url = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.SlideId);
            
            CreateTable(
                "dbo.SocialLinks",
                c => new
                    {
                        SocialLinkId = c.Int(nullable: false, identity: true),
                        Icon = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 150),
                        SettingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialLinkId)
                .ForeignKey("dbo.Settings", t => t.SettingId, cascadeDelete: true)
                .Index(t => t.SettingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialLinks", "SettingId", "dbo.Settings");
            DropForeignKey("dbo.Projects", "CategoryId", "dbo.ProjectCategories");
            DropForeignKey("dbo.AuthorSocialLinks", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Blogs", "BlogcategoryId", "dbo.BlogCategories");
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors");
            DropIndex("dbo.SocialLinks", new[] { "SettingId" });
            DropIndex("dbo.Projects", new[] { "CategoryId" });
            DropIndex("dbo.AuthorSocialLinks", new[] { "AuthorId" });
            DropIndex("dbo.Blogs", new[] { "BlogcategoryId" });
            DropIndex("dbo.Blogs", new[] { "AuthorId" });
            DropTable("dbo.SocialLinks");
            DropTable("dbo.Slides");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectCategories");
            DropTable("dbo.AuthorSocialLinks");
            DropTable("dbo.BlogCategories");
            DropTable("dbo.Blogs");
            DropTable("dbo.Authors");
            DropTable("dbo.Abouts");
        }
    }
}
