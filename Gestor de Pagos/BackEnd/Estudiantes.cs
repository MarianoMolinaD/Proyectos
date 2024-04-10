using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Estudiantes
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }

        public Estudiantes(string? nombres, string? apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }
    }
}
