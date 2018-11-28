using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_Moviles.Api.Models
{
    [Table("Publicacion")]
    public class Publicacion
    {
        [Key]
        public int IdPublicacion { get; set; }

        [MaxLength(250)]
        public string Descripcion { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public int MeGusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
    }
}