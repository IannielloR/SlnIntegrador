namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Paciente", "NroHistorialClinica", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Paciente", "NroHistorialClinica");
        }
    }
}
