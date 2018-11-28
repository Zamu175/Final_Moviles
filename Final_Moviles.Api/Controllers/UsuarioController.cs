using Final_Moviles.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final_Moviles.Api.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            using (var context = new InstagramContext())
            {
                return context.Usuarios.ToList();
            }
        }

        [HttpGet]
        public Usuario Get(int id)
        {
            using (var context = new InstagramContext())
            {
                return context.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var context = new InstagramContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();

                return Ok(usuario);
            }
        }

        [HttpPut]
        public Usuario Put(Usuario usuario)
        {
            using (var context = new InstagramContext())
            {
                var usuarioAct = context.Usuarios.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);

                usuarioAct.Nombre = usuario.Nombre;
                usuarioAct.Genero = usuario.Genero;
                usuarioAct.NomUsuario = usuario.NomUsuario;
                usuarioAct.Imagen = usuario.Imagen;
                usuarioAct.Telefono = usuario.Telefono;

                context.SaveChanges();

                return usuario;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new InstagramContext())
            {
                var usuarioDel = context.Usuarios.FirstOrDefault(x => x.IdUsuario == id);

                context.Usuarios.Remove(usuarioDel);
                context.SaveChanges();

                return true;
            }
        }
    }
}
