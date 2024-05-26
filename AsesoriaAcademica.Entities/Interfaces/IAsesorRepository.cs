using AsesoriaAcademica.Entities.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.Entities.Interfaces
{
    
     public interface IAsesorRepository //Tiene la definicion
       {

        List<Asesore> listar();
        List<Asesore> filtrar(string nombre);

        void agregar(Asesore oAsesor);
        void editar(Asesore oAsesor);
        void eliminar(int idAsesor);
    }
    
}
