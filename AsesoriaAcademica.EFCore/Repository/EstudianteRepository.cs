using AsesoriaAcademica.Entities.Interfaces;
using AsesoriaAcademica.Entities.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.EFCore.Repository
{
    public class EstudianteRepository : IEstudianteRepository
    {

        private readonly GestionAsesoriaAcademicaContext _bd;
        public EstudianteRepository(GestionAsesoriaAcademicaContext bd)
        {
            this._bd = bd;
        }

        public void agregar(Estudiante oEstudiante)
        {
            _bd.Estudiantes.Add(oEstudiante);
        }

        public void editar(Estudiante oEstudiante)
        {
            var obj = _bd.Estudiantes
                .Where(p => p.EstudianteId == oEstudiante.EstudianteId).FirstOrDefault();
             if (obj != null)
            {
                obj.Nombre = oEstudiante.Nombre;
                obj.Email = oEstudiante.Email;
            }
        }

        public void eliminar(int idEstudiante)
        {
            var obj = _bd.Estudiantes
                .Where(p => p.EstudianteId == idEstudiante).FirstOrDefault();
            if (obj != null)
            {
                obj.Bhabilitado = 0;
               
            }
        }

        public List<Estudiante> filtrar(string nombre)
        {
            return _bd.Estudiantes.Where(p => p.Nombre.Contains(nombre) && p.Bhabilitado == 1).ToList();
        }

        public List<Estudiante> listar()
        {
            return _bd.Estudiantes.Where(p => p.Bhabilitado == 1).ToList();
        }
    }
}
