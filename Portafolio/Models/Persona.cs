namespace Portafolio.Models
{
    public class Persona
    {
        public string? Nombre{ get; set; }
        public int? Eddad { get; set; }

        public Persona(string? nombre, int? eddad)
        {
            Nombre = nombre;
            Eddad = eddad;
        }
    }
}
