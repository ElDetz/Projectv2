using AsesoriaAcademica.Entities.Interfaces;
using AsesoriaAcademica.Entities.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.EFCore.Repository
{
    public class AsesorRepository : IAsesorRepository
    {

        private readonly GestionAsesoriaAcademicaContext _bd;
        public AsesorRepository(GestionAsesoriaAcademicaContext bd)
        {
            this._bd = bd;
        }

        public void agregar(Asesore oAsesor)
        {
            _bd.Asesores.Add(oAsesor);
        }

        public void editar(Asesore oAsesor)
        {
            var obj = _bd.Asesores
                .Where(p => p.AsesorId == oAsesor.AsesorId).FirstOrDefault();
            if (obj != null)
            {
                obj.AsesorId = oAsesor.AsesorId;
                obj.Email = oAsesor.Email;
            }
        }

        public void eliminar(int idAsesor)
        {
            var obj = _bd.Asesores
                .Where(p => p.AsesorId == idAsesor).FirstOrDefault();
            if (obj != null)
            {
                obj.Bhabilitado = 0;
            }
        }

        public List<Asesore> filtrar(string nombre)
        {
            return _bd.Asesores.Where(p => p.Nombre.Contains(nombre) && p.Bhabilitado == 1).ToList();
        }

        public List<Asesore> listar()
        {
            return _bd.Asesores.Where(p => p.Bhabilitado == 1).ToList();
        }
    }
}
