using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class EquipoController : Controller
    { 

        // GET: EquipoController
        /*public ActionResult Index()
        {
           IEnumerable<DTOListarEquipo> equipos = new List<DTOListarEquipo>();
                equipos = CUListarEquipos.Ejecutar();
            return View(equipos);
        }

        // GET: EquipoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EquipoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {*/
            /*[HttpPost]
            public IActionResult Create(string tipo)
            {
                if (tipo == "Telescopio")
                {
                    return RedirectToAction("CreateTelescopio");
                }

                if (tipo == "Camara")
                {
                    return RedirectToAction("CreateCamara");
                }

                if (tipo == "Montura")
                {
                    return RedirectToAction("CreateMontura");
                }

                return RedirectToAction("CreateOcular");
            */          /*try
           {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EquipoController/Edit/5
        public ActionResult Edit(int id)
        {
            DTOEquipo dtoEquipoBuscado = CUBuscarEquipo.Ejecutar(id);
            return View(dtoEquipoBuscado);
        }

        // POST: EquipoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DTOEquipo dtoEquipo)
        {
            try
            {
                CUEditarEquipo.Ejecutar(id, dtoEquipo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EquipoController/Delete/5
        public ActionResult Delete(int id)
        {
            DTOEquipo dtoEquipoBuscado = CUBuscarEquipo.Ejecutar(id);
            return View(dtoEquipoBuscado);
        }

        // POST: EquipoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (id > 0) { 
                    CUEliminarEquipo.Ejecutar(id);
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }*/
    }
}


