namespace Final_Moviles.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class commitdos : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Seguridad");
            CreateTable(
                "dbo.Publicacion",
                c => new
                    {
                        IdPublicacion = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 250),
                        FechaPublicacion = c.DateTime(nullable: false),
                        MeGusta = c.Int(nullable: false),
                        MeDisgusta = c.Int(nullable: false),
                        VecesCompartido = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPublicacion);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        NomUsuario = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 100),
                        Imagen = c.String(nullable: false, maxLength: 100),
                        Genero = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.IdUsuario);
        }      
    }
}
