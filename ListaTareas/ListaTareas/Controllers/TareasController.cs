using ListaTareas.Models;
using ListaTareas.Services;
using Microsoft.AspNetCore.Mvc;


namespace ListaTareas.Controllers
{
    public class TareasController : Controller
    {
        private readonly IRepositorioTareas repositorioTareas;
        public TareasController(IRepositorioTareas repositorioTareas)
        {
            this.repositorioTareas = repositorioTareas;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
          
            var tareas = await repositorioTareas.Obtener();
            return View(tareas);
        }

     
        public async Task<IActionResult> Borrar(int id)
        {
            var tarea = await repositorioTareas.ObtenerPorId(id);

            return View(tarea);

        }
        [HttpPost]
        public async Task<IActionResult> BorrarTarea(int id)
        {
            await repositorioTareas.Borrar(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Tareas tareas)
        {

            await repositorioTareas.Crear(tareas);

            

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Editar(int id)
        {
            var tarea = await repositorioTareas.ObtenerPorId(id);

            return View(tarea);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Tareas tareas)
        {
            await repositorioTareas.Actualizar(tareas);

            return RedirectToAction("Index");
        }

        public IActionResult Crear()
        {
            return View();
        }
    }
}
