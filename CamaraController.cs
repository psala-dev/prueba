using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CamaraController : Controller
    {
      
        // GET: CamaraController
        /*public ActionResult Index()
        {
            return View();
        }

        // GET: CamaraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CamaraController/Create
        public ActionResult Create()
        {
            DTOCamara dtoAltaCamara = new DTOCamara();
            try
            {
                dtoAltaCamara.TipoSensor = CUListadoSensor.Ejecutar();
            }
            catch (Exception ex)
            {
                //FALTA EXCEPTION
            }
            return View(dtoAltaCamara);

        }

        // POST: CamaraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTOCamara dtoAltaCamara)
        {

            dtoAltaCamara.TipoSensor = CUListadoSensor.Ejecutar();

            try
            {
                CUAltaCamara.Ejecutar(dtoAltaCamara);
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View(dtoAltaCamara);

            }
        }

        // GET: CamaraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CamaraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CamaraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CamaraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
