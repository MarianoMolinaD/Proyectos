using System.Collections;

namespace Portafolio.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Proyectos> Proyectos { get; set; }

        public HomeIndexViewModel(IEnumerable<Proyectos> proyectos)
        {
            Proyectos = proyectos;
        }
    }
}
