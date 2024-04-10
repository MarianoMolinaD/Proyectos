using Microsoft.AspNetCore.Mvc;

namespace GestionEstudiantes.Controllers
{
    public class EstudiantesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
