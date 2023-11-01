using Microsoft.AspNetCore.Mvc;

namespace Estacionamiento_Proyecto_PNT_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
