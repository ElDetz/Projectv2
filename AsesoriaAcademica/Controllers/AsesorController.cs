using AsesoriaAcademica.DTO.Asesor;
using AsesoriaAcademica.DTO.Estudiante;
using AsesoriaAcademica.Entities.Interfaces;
using AsesoriaAcademica.Entities.POCOS;
using Microsoft.AspNetCore.Mvc;

namespace AsesoriaAcademica.Controllers
{
    public class AsesorController : Controller
    {
        
        private readonly IAsesorRepository _asesor;
        private readonly IUnitOfWorkRepository _unit;
        public AsesorController(IAsesorRepository asesor, IUnitOfWorkRepository unit)
        {
            this._asesor = asesor;
            this._unit = unit;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<ListarAsesorDTO> listar()
        {

            //return _estudiante.listar();

            return _asesor.listar().Select(P => new ListarAsesorDTO
            {
                AsesorId = P.AsesorId,
                Nombre = P.Nombre,
                Apellido = P.Apellido,
                Email = P.Email,
                Departamento = P.Departamento

            }).ToList();


        }

        public List<ListarAsesorDTO> filtrar(string nombre)
        {

            return _asesor.filtrar(nombre).Select(P => new ListarAsesorDTO
            {
                AsesorId = P.AsesorId,
                Nombre = P.Nombre,
                Apellido = P.Apellido,
                Email = P.Email,
                Departamento = P.Departamento

            }).ToList();


        }

        public int eliminarAsesor(int idAsesor)
        {

            int rpta = 0;
            try
            {
                _asesor.eliminar(idAsesor);
                _unit.SavesChanges();
                rpta = 1;
            }
            catch (Exception)
            {
                rpta = 0;
            }
            return rpta;
        }

    }
}

