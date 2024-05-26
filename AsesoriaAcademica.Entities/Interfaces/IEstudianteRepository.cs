using AsesoriaAcademica.Entities.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.Entities.Interfaces
{
    public interface IEstudianteRepository //Tiene la definicion
    {

        List<Estudiante> listar();
        List<Estudiante> filtrar(string nombre);

        void agregar(Estudiante oEstudiante);
        void editar(Estudiante oEstudiante);
        void eliminar(int idEstudiante);
    }
}
