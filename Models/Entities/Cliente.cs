using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Cliente
    {
        [Key, StringLength(10)]
        public string Id { get; set; }
        [StringLength(50), AllowNull]
        public string? Nombre { get; set; }
        [StringLength(50), AllowNull]
        public string? Apellido { get; set; }
        [AllowNull]
        public int? DomicilioId { get; set; }
        [StringLength(50), AllowNull]
        public string? RazonSocial { get; set; }
        [StringLength(20), AllowNull]
        public string? Telefono { get; set; }
        [StringLength(50), AllowNull]
        public string? Email { get; set; }

        [NotMapped]
        public Domicilio? Domicilio { get; set; }

        [NotMapped]

        public Vehiculo? Vehiculo { get; set; }
    }
}
