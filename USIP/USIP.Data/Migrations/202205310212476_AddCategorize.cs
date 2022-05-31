namespace USIP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategorize : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "IdCategory", "dbo.Category");
            DropIndex("dbo.Product", new[] { "IdCategory" });
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
            
            DropColumn("dbo.Product", "IdCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "IdCategory", c => c.Int(nullable: false));
            DropForeignKey("dbo.Categorize", "IdProduct", "dbo.Product");
            DropForeignKey("dbo.Categorize", "IdCategory", "dbo.Category");
            DropIndex("dbo.Categorize", new[] { "IdCategory" });
            DropIndex("dbo.Categorize", new[] { "IdProduct" });
            DropTable("dbo.Categorize");
            CreateIndex("dbo.Product", "IdCategory");
            AddForeignKey("dbo.Product", "IdCategory", "dbo.Category", "Id", cascadeDelete: true);
        }
    }
}
