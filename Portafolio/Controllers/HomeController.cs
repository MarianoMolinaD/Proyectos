using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IConfiguration configuracion;

        public HomeController(IRepositorioProyectos repositorioProyectos)
        {

            this.repositorioProyectos = repositorioProyectos;

        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.obtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel(proyectos);
            return View(modelo);
        }



        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.obtenerProyectos();

            return View(proyectos);
        }
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoVIewModel contactoVIewModel)
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}