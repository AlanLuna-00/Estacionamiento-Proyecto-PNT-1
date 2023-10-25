using Estacionamiento_Proyecto_PNT_1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_Proyecto_PNT_1.Models
{
    public class Context : DbContext
    {

        public DbSet<Cochera> Cocheras { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<MedioDePago> MediosDePago { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HIIRCOT; Initial Catalog=EstacionamientoDB; Integrated Security=true; Encrypt = true; TrustServerCertificate = true");
        }
    }
}
