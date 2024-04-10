using Portafolio.Models;

namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
        List<Proyectos> obtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyectos> obtenerProyectos()
        {
            return new List<Proyectos>() {
                new Proyectos
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP net core",
                Link = "https://amazon.com",
                ImagenURL  = "/images/amazon.png"
            },  new Proyectos
            {
                Titulo = "New York Times",
                Descripcion = "Paginas de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL  = "/images/nyt.png"
            },  new Proyectos
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL  = "/images/reddit.png"
            },  new Proyectos
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para comprar video jeugos",
                Link = "https://store.steampowered.com",
                ImagenURL  = "/images/steam.png"
            },

            };
        }
        
    }
}
