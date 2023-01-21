namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        PacienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 8000, unicode: false),
                        Apellido = c.String(maxLength: 8000, unicode: false),
                        Domicilio = c.String(maxLength: 8000, unicode: false),
                        Telefono = c.String(maxLength: 8000, unicode: false),
                        Email = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paciente");
        }
    }
}
