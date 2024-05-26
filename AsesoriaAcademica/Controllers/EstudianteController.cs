using AsesoriaAcademica.DTO.Estudiante;
using AsesoriaAcademica.EFCore;
using AsesoriaAcademica.Entities.Interfaces;
using AsesoriaAcademica.Entities.POCOS;
using Microsoft.AspNetCore.Mvc;

namespace AsesoriaAcademica.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly IEstudianteRepository _estudiante;
        private readonly IUnitOfWorkRepository _unit;
        public EstudianteController(IEstudianteRepository estudiante, IUnitOfWorkRepository unit ) {
            this._estudiante = estudiante;
            this._unit = unit;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<ListarEstudianteDTO> listar()
        {

            //return _estudiante.listar();

            return _estudiante.listar().Select(P => new ListarEstudianteDTO
            {
                EstudianteId = P.EstudianteId,
                Nombre = P.Nombre,
                Email = P.Email

            }).ToList();


        }

        public List<ListarEstudianteDTO> filtrar(string nombre)
        {

            //return _estudiante.filtrar(nombre);

            return _estudiante.filtrar(nombre).Select(P => new ListarEstudianteDTO
            {
                EstudianteId = P.EstudianteId,
                Nombre = P.Nombre,
                Email = P.Email

            }).ToList();


        }

        public int eliminarEstudiante(int idEstudiante)
        {

            int rpta = 0;
            try
            {
                _estudiante.eliminar(idEstudiante);
                _unit.SavesChanges();
                rpta = 1;
            }catch (Exception) { 
                rpta = 0;
            }
            return rpta;
        }

        public int guardarEstudiante(GuardarEstudianteDTO oGuardarEstudianteDTO)
        {
            int rpta = 0;

            try
            {
                Estudiante oEstudiante = new Estudiante();
                oEstudiante.EstudianteId = oGuardarEstudianteDTO.EstudianteId;
                oEstudiante.Nombre = oGuardarEstudianteDTO.NombreEstudiante;
                oEstudiante.Apellido = oGuardarEstudianteDTO.ApellidoEstudiante;
                oEstudiante.Email = oGuardarEstudianteDTO.EmailEstudiante;
                oEstudiante.Telefono = oGuardarEstudianteDTO.TelefonoEstudiante;
                oEstudiante.Bhabilitado = oGuardarEstudianteDTO.BhabilitadoE;

                if (oEstudiante.EstudianteId == 0)
                {
                    _estudiante.agregar(oEstudiante);
                    _unit.SavesChanges();

                    rpta = 1;
                }
                else
                {
                    _estudiante.editar(oEstudiante);
                    _unit.SavesChanges();
                    rpta = 1;
                }
            }
            catch (Exception)
            {
                rpta = 0;
            }
            return rpta;
        }


        //public int guardarEstudiante(Estudiante oEstudiante)
        //{
        //    int rpta = 0;

        //    try
        //    {

        //        if (oEstudiante.EstudianteId == 0)
        //        {
        //            _estudiante.agregar(oEstudiante);
        //            _unit.SavesChanges();

        //            rpta = 1;
        //        }
        //        else
        //        {
        //            _estudiante.editar(oEstudiante);
        //            _unit.SavesChanges();
        //            rpta = 1;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        rpta = 0;
        //    }
        //    return rpta;
        //}
    }
}
