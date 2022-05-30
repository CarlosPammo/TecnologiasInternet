namespace USIP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMyModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                        IsSpecialOffert = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categorize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdProduct = c.Int(nullable: false),
                        IdCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.IdCategory, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.IdProduct, cascadeDelete: true)
                .Index(t => t.IdProduct)
                .Index(t => t.IdCategory);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categorize", "IdProduct", "dbo.Product");
            DropForeignKey("dbo.Categorize", "IdCategory", "dbo.Category");
            DropIndex("dbo.Categorize", new[] { "IdCategory" });
            DropIndex("dbo.Categorize", new[] { "IdProduct" });
            DropTable("dbo.Categorize");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
