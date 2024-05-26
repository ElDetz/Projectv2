using AsesoriaAcademica.Entities.Interfaces;
using AsesoriaAcademica.Entities.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.EFCore.Repository
{
    internal class CitaRepository : ICitaRepository
    {

        private readonly GestionAsesoriaAcademicaContext _bd;
        public CitaRepository(GestionAsesoriaAcademicaContext bd)
        {
            this._bd = bd;
        }

        public void agregar(Cita oCita)
        {
            _bd.Citas.Add(oCita);
        }

        public void editar(Cita oCita)
        {
            var obj = _bd.Citas
                .Where(p => p.CitaId == oCita.CitaId).FirstOrDefault();
            if (obj != null)
            {
                obj.AsesorId = oCita.AsesorId;
                obj.Motivo = oCita.Motivo;
            }
        }

        public void eliminar(int idCita)
        {
            var obj = _bd.Citas
                .Where(p => p.CitaId == idCita).FirstOrDefault();
            if (obj != null)
            {
                
            }
        }

        public List<Cita> filtrar(int asesorId) // Filtrar segun ID Asesor
        {
            return _bd.Citas.Where(p => p.AsesorId == asesorId && p.Bhabilitado == 1).ToList();
        }

        public List<Cita> listar()
        {
            return _bd.Citas.Where(p => p.Bhabilitado == 1).ToList();
        }
    }
}
