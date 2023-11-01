using Microsoft.AspNetCore.Mvc;
using Estacionamiento_Proyecto_PNT_1.Models.Entities;
using Estacionamiento_Proyecto_PNT_1.Utils;
using Estacionamiento_Proyecto_PNT_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_Proyecto_PNT_1.Controllers
{
    public class ClienteController : Controller
    {

        private Context context = new Context();
        [HttpGet]
        public async Task<IActionResult> Mostrar()
        {
            List<Cliente> Clientes = await context.Clientes.ToListAsync();

            foreach (var cliente in Clientes)
            {
                if (cliente.DomicilioId != null)
                {
                    Domicilio? domicilio = await context.Domicilios.FindAsync(cliente.DomicilioId);
                    cliente.Domicilio = domicilio;
                }

                Vehiculo? vehiculo = await context.Vehiculos.FirstOrDefaultAsync(v => v.ClienteId == cliente.Id);

                if (vehiculo != null)
                {
                    cliente.Vehiculo = vehiculo;
                }
            }




            return View(Clientes);

        }

        public async Task<IActionResult> Eliminar(string id)
        {
            Cliente cliente = await context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                await context.SaveChangesAsync();
            }
            return RedirectToAction("Mostrar");
        }

       
    }
}
