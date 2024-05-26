using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.DTO.Cita
{
    public class ListarCitaDTO
    {
        public int CitaId { get; set; }

        public int EstudianteID { get; set; }

        public int  AsesorID { get; set; }

        public DateTime FechaHora { get; set; }

        public string? Motivo { get; set; }


    }
}
