using System.ComponentModel.DataAnnotations;

namespace ListaTareas.Models
{
    public class Tareas
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Tarea { get; set; }
        public string Persona { get; set; }
        public int Precio { get; set; }
    }
}
