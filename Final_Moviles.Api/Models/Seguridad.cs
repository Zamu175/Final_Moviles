using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Moviles.Api.Models
{
    [Table("Seguridad")]
    public class Seguridad
    {
        [Key]
        public int IdSeguridad { get; set; }

        [MaxLength(100)]
        [Required]
        public string Usuario { get; set; }

        [MaxLength(100)]
        [Required]
        public string contraseña { get; set; }
    }
}