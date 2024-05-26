using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.DTO.Estudiante
{
    public class GuardarEstudianteDTO

    {
        public int EstudianteId { get; set; }
        public string NombreEstudiante { get; set; } = null!;

        public string ApellidoEstudiante { get; set; } = null!;

        public string EmailEstudiante { get; set; } = null!;

        public string TelefonoEstudiante { get; set; } = null!;

        public int BhabilitadoE { get; set; }


    }
}
