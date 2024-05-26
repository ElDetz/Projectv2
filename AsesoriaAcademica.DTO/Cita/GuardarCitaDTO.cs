using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.DTO.Cita
{
    public class GuardarCitaDTO

    {
        public int CitaId { get; set; }

        public int EstudianteId { get; set; }

        public int AsesorId { get; set; }

        public DateTime FechaHora { get; set; }

        public string? Motivo { get; set; }
        public int? Bhabilitado { get; set; }


    }
}
