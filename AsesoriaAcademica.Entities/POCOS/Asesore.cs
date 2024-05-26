using System;
using System.Collections.Generic;

namespace AsesoriaAcademica.Entities.POCOS;

public partial class Asesore
{
    public int AsesorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Departamento { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
