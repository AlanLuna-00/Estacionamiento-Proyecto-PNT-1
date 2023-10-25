using Estacionamiento_Proyecto_PNT_1.Utils;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Vehiculo
    {
        [Key, StringLength(12)]
        public string Patente { get; set; }

        [Required, EnumDataType(typeof(TipoVehiculo))]
        public TipoVehiculo Tipo { get; set; }

        [AllowNull]
        public string? ClienteId { get; set; }

    }
}
