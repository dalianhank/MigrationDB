namespace GeFeng.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        BlogCategory = c.String(nullable: false),
                        BlogTitle = c.String(nullable: false),
                        BlogContent = c.String(nullable: false),
                        BlogCreateDate = c.DateTime(nullable: false),
                        BlogImageData = c.Binary(),
                        BlogImageMimeType = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        CommentCreateDate = c.DateTime(nullable: false),
                        CommentUser = c.String(nullable: false),
                        CommentCotent = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        ContactEmail = c.String(),
                        ContactCreateDate = c.DateTime(nullable: false),
                        ContactMessage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        UserName = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 160),
                        LastName = c.String(nullable: false, maxLength: 160),
                        Country = c.String(nullable: false, maxLength: 40),
                        Address = c.String(maxLength: 70),
                        City = c.String(maxLength: 40),
                        State = c.String(maxLength: 40),
                        PostalCode = c.String(maxLength: 10),
                        Phone = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comments", new[] { "BlogId" });
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropTable("dbo.Clients");
            DropTable("dbo.Contacts");
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
        }
    }
}
