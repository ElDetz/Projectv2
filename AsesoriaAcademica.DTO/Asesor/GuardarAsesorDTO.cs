using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.DTO.Asesor
{
    public class GuardarAsesorDTO

    {
        public int AsesorId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? Departamento { get; set; }

        public int? Bhabilitado { get; set; }


    }
}
