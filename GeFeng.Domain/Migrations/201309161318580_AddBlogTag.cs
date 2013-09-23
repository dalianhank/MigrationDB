namespace GeFeng.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogTag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogTag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogTag");
        }
    }
}
