namespace USIP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredImageUrlColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "ImageUrl", c => c.String(nullable: false));
        }
    }
}
