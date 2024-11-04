using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class GatoController : Controller
    {
        public IActionResult Index()
        {
            List<Gato> gatos = new List<Gato>
            {
                new Gato { Nombre = "Felix", Apellido = "García" },
                new Gato { Nombre = "Tom", Apellido = "Martínez" }
            };
            return View(gatos);
        }
    }
}
