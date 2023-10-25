using Estacionamiento_Proyecto_PNT_1.Utils;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Cochera
    {
        [Key]
        public int NumeroDeCochera { get; set; }

        [EnumDataType(typeof(TipoDeAbono)), AllowNull]
        public TipoDeAbono? TipoDeAbono { get; set; }

        [AllowNull]
        public string? Patente { get; set; }

        [AllowNull]
        public int? ClienteId { get; set; }
    }
}
