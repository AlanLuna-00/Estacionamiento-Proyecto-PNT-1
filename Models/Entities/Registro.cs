using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

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
        [AllowNull]
        public int? HoraSalida { get; set; }

        [Required]
        public int NumeroDeCochera { get; set; }
    }
}
