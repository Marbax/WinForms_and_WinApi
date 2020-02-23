namespace GoodsCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        Provider_Id = c.Int(nullable: false),
                        Category_Id1 = c.Int(),
                        Provider_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id1)
                .ForeignKey("dbo.Providers", t => t.Provider_Id1)
                .Index(t => t.Category_Id1)
                .Index(t => t.Provider_Id1);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Provider_Id1", "dbo.Providers");
            DropForeignKey("dbo.Products", "Category_Id1", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Provider_Id1" });
            DropIndex("dbo.Products", new[] { "Category_Id1" });
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
