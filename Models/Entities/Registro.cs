using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Patente { get; set; }

        [Required]
        public int HoraIngreso { get; set; }

        [Required]
        public int HoraEgreso { get; set; }
    }
}
