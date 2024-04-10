using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    internal class Estudiantes
    {
        public string Carnet { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Facultad { get; set; }

        public Estudiantes(string carnet, string nombres, string apellidos, string correo, string telefono, string facultad)
        {
            Carnet = carnet;
            Nombres = nombres;
            Apellidos = apellidos;
            Correo = correo;
            Telefono = telefono;
            Facultad = facultad;
        }
    }

}
