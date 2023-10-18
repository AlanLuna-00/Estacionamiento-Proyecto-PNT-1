using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Cliente
    {
        [Key, StringLength(10)]
        public string Id { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        [StringLength(50)]
        public string? Apellido { get; set; }
        public int? DomicilioId { get; set; }
        [StringLength(50)]
        public string? RazonSocial { get; set; }
        [StringLength(20)]
        public string? Telefono { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
    }
}
