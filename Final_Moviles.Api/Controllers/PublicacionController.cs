using Final_Moviles.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final_Moviles.Api.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new InstagramContext())
            {
                return context.Publicaciones.ToList();
            }
        }

        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new InstagramContext())
            {
                return context.Publicaciones.FirstOrDefault(x => x.IdPublicacion == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var context = new InstagramContext())
            {
                context.Publicaciones.Add(publicacion);
                context.SaveChanges();

                return Ok(publicacion);
            }
        }

        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new InstagramContext())
            {
                var publicacionAct = context.Publicaciones.FirstOrDefault(x => x.IdPublicacion == publicacion.IdPublicacion);

                publicacionAct.Descripcion = publicacion.Descripcion;
                publicacionAct.FechaPublicacion = publicacion.FechaPublicacion;
                publicacionAct.MeDisgusta = publicacion.MeDisgusta;
                publicacionAct.MeGusta = publicacion.MeGusta;
                publicacionAct.VecesCompartido = publicacion.VecesCompartido;

                context.SaveChanges();

                return publicacion;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new InstagramContext())
            {
                var usuarioDel = context.Publicaciones.FirstOrDefault(x => x.IdPublicacion == id);

                context.Publicaciones.Remove(usuarioDel);
                context.SaveChanges();

                return true;
            }
        }
    }
}
