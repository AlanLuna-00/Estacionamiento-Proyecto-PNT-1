using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class MedioDePago
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(25)]
        public string Nombre { get; set; }

        [Required]
        public double Porcentaje { get; set; }
    }
}
