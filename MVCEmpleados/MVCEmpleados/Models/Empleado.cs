using System;
using System.Collections.Generic;

namespace MVCEmpleados.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Puesto { get; set; }
}
