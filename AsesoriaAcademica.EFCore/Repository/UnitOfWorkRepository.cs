using AsesoriaAcademica.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.EFCore.Repository
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository //Confirmacion de una accion
    {
        public readonly GestionAsesoriaAcademicaContext _context;

        public UnitOfWorkRepository(GestionAsesoriaAcademicaContext context)
        {
            this._context = context;
        }
        public int SavesChanges()
        {
            return _context.SaveChanges();   
        }
    }
}
