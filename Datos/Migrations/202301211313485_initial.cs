namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 8000, unicode: false),
                        Apellido = c.String(maxLength: 8000, unicode: false),
                        Domicilio = c.String(maxLength: 8000, unicode: false),
                        Telefono = c.String(maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 8000, unicode: false),
                        Especialidad = c.String(maxLength: 8000, unicode: false),
                        Matricula = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.MedicoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
