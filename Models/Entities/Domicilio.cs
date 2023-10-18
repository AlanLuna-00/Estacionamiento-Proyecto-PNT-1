using System.ComponentModel.DataAnnotations
using System.Runtime.InteropServices;

namespace Estacionamiento_Proyecto_PNT_1.Models.Entities
{
    public class Domicilio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Calle { get; set; }
        [Required]
        public int Numero { get; set; }
        public int? Piso { get; set; }
        public string? Departamento { get; set; }

        public string? CodPostal { get; set; }
        [Required]
        public string Ciudad { get; set; }

    }
}
