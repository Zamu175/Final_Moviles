using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_Moviles.Api.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(100)]
        [Required]
        public string NomUsuario { get; set; }

        [MaxLength(100)]
        [Required]
        public string Telefono { get; set; }

        [MaxLength(100)]
        [Required]
        public string Imagen { get; set; }

        [MaxLength(20)]
        [Required]
        public string Genero { get; set; }
    }
}