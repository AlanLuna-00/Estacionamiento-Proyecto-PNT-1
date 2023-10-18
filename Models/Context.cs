using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_Proyecto_PNT_1.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HIIRCOT; Initial Catalog=EstacionamientoDB; Integrated Security=true; Encrypt = true; TrustServerCertificate = true");
        }
    }
}
