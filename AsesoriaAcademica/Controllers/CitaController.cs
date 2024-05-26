using AsesoriaAcademica.DTO.Cita;
using AsesoriaAcademica.Entities.Interfaces;
using AsesoriaAcademica.Entities.POCOS;
using Microsoft.AspNetCore.Mvc;

namespace AsesoriaAcademica.Controllers
{
    public class CitaController : Controller
    {
       
        private readonly ICitaRepository _cita;
        private readonly IUnitOfWorkRepository _unit;
        public CitaController(ICitaRepository cita, IUnitOfWorkRepository unit)
        {
            this._cita = cita;
            this._unit = unit;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<Cita> listar()
        {

            return _cita.listar();

        }

        public List<Cita> filtrar(int idCita)
        {

            return _cita.filtrar(idCita);


        }

        public int guardarCita(Cita oCita)
        {
            int rpta = 0;

            try
            {

                if (oCita.CitaId == 0)
                {
                    _cita.agregar(oCita);
                    _unit.SavesChanges();

                    rpta = 1;
                }
                else
                {
                    _cita.editar(oCita);
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
    }
}
