using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final_Moviles.Api.Models
{
    public class InstagramContext : DbContext
    {
        public InstagramContext() : base("InstagramConnection")
        {

        }
        public DbSet<Seguridad> Seguridades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}