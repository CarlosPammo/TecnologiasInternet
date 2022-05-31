namespace USIP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategorize : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categorize", "IdCategory", "dbo.Category");
            DropForeignKey("dbo.Categorize", "IdProduct", "dbo.Product");
            DropIndex("dbo.Categorize", new[] { "IdProduct" });
            DropIndex("dbo.Categorize", new[] { "IdCategory" });
            AddColumn("dbo.Product", "IdCategory", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "IdCategory");
            AddForeignKey("dbo.Product", "IdCategory", "dbo.Category", "Id", cascadeDelete: true);
            DropTable("dbo.Categorize");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categorize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdProduct = c.Int(nullable: false),
                        IdCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Product", "IdCategory", "dbo.Category");
            DropIndex("dbo.Product", new[] { "IdCategory" });
            DropColumn("dbo.Product", "IdCategory");
            CreateIndex("dbo.Categorize", "IdCategory");
            CreateIndex("dbo.Categorize", "IdProduct");
            AddForeignKey("dbo.Categorize", "IdProduct", "dbo.Product", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Categorize", "IdCategory", "dbo.Category", "Id", cascadeDelete: true);
        }
    }
}
