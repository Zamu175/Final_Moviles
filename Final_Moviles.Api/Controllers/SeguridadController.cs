using Final_Moviles.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Final_Moviles.Api.Controllers
{
    public class SeguridadController : ApiController
    {
        [HttpGet]
        public IEnumerable<Seguridad> Get()
        {
            using (var context = new InstagramContext())
            {
                return context.Seguridades.ToList();
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Seguridad seguridad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var context = new InstagramContext())
            {
                context.Seguridades.Add(seguridad);
                context.SaveChanges();

                return Ok(seguridad);
            }
        }
    }
}
