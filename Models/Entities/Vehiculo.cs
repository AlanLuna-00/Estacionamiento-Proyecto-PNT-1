using Estacionamiento_Proyecto_PNT_1.Utils;
using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Vehiculo
    {
        [Key, StringLength(12)]
        public string Patente { get; set; }

        [Required]
        public TipoVehiculo Tipo { get; set; }

        public string? ClienteId { get; set; }

        public TipoDeAbono? TipoDeAbono { get; set; }
    }
}
