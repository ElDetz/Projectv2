using System;
using System.Collections.Generic;

namespace AsesoriaAcademica.Entities.POCOS;

public partial class Cita
{
    public int CitaId { get; set; }

    public int EstudianteId { get; set; }

    public int AsesorId { get; set; }

    public DateTime FechaHora { get; set; }

    public string? Motivo { get; set; }
    public int? Bhabilitado { get; set; }

    public virtual Asesore Asesor { get; set; } = null!;

    public virtual Estudiante Estudiante { get; set; } = null!;
}
