using Actividad1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Actividad1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Crear una instancia de Empleado y asignar valores
            var empleado = new Empleado
            {
                Id = 1,
                NombreCompleto = "Juan Pérez",
                FechaContratacion = "2024-10-25",
                Salario = "3500.50",
                Edad = 30
            };

            // Casting explícito
            int edadDelEmpleado = (int)empleado;

            // Pasamos el empleado a la vista para mostrarlo
            ViewBag.EdadDelEmpleado = edadDelEmpleado; // Mostramos el resultado del casting
            return View(empleado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
