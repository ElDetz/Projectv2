using AsesoriaAcademica.Entities.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.Entities.Interfaces
{
    public interface ICitaRepository //Tiene la definicion
    {

        List<Cita> listar();
        List<Cita> filtrar(int AsesorId);

        void agregar(Cita oCita);
        void editar(Cita oCita);
        void eliminar(int idCita);
    }
}
