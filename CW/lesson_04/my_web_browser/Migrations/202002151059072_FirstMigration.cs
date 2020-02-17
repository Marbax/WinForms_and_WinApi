namespace my_web_browser.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                        Category_Id = c.Int(nullable: false),
                        Category_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id1)
                .Index(t => t.Category_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sites", "Category_Id1", "dbo.Categories");
            DropIndex("dbo.Sites", new[] { "Category_Id1" });
            DropTable("dbo.Sites");
            DropTable("dbo.Categories");
        }
    }
}
