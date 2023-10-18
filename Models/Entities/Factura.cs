using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        public int? RegistroId { get; set; }

        [Required]
        public int Precio { get; set; }

        public int? Patente { get; set; }

        public int MedioDePagoId { get; set; }
    }
}
