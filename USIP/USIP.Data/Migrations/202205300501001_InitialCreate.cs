namespace USIP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        Llave = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Llave);
            
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        Llave = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Codigo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Llave);
            
            CreateTable(
                "dbo.Estudia",
                c => new
                    {
                        Llave = c.Int(nullable: false, identity: true),
                        IdEstudiante = c.Int(nullable: false),
                        IdCarrera = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Llave)
                .ForeignKey("dbo.Carrera", t => t.IdCarrera, cascadeDelete: true)
                .ForeignKey("dbo.Estudiante", t => t.IdEstudiante, cascadeDelete: true)
                .Index(t => t.IdEstudiante)
                .Index(t => t.IdCarrera);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estudia", "IdEstudiante", "dbo.Estudiante");
            DropForeignKey("dbo.Estudia", "IdCarrera", "dbo.Carrera");
            DropIndex("dbo.Estudia", new[] { "IdCarrera" });
            DropIndex("dbo.Estudia", new[] { "IdEstudiante" });
            DropTable("dbo.Estudia");
            DropTable("dbo.Carrera");
            DropTable("dbo.Estudiante");
        }
    }
}
