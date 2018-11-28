namespace Final_Moviles.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seguridad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 100),
                        contraseña = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seguridad");
        }
    }
}
