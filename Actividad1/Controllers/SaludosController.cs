using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class SaludosController : Controller
    {
        // Esta acción se ejecuta cuando el usuario accede a la ruta /saludos/jhordan
        // No recibe ningún parámetro porque la ruta es estática
        [Route("saludos/jhordan")]
        public IActionResult Jhordan()
        {
            return Content("Saludos Jhordan");
        }
        // Esta acción se ejecuta cuando el usuario accede a la ruta /saludos/pacheco
        [Route("saludos/pacheco")]
        public IActionResult Pacheco()
        {
            return Content("Saludos Pacheco");
        }
        // Esta es una ruta dinámica. El "{nombre}" en la ruta indica que se espera
        // recibir un valor en la URL, que se asignará al parámetro "nombre"
        [Route("saludos/{nombre}")]
        public IActionResult SaludosDinamico(string nombre)
        {
            return Content($"Saludos {nombre}");
        }
    }
}
