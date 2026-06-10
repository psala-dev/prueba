using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class MonturaController : Controller
    {
        
        // GET: MonturaController
        /*public ActionResult Index()
        {
            return View();
        }

        // GET: MonturaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonturaController/Create
        public ActionResult Create()
        {
       
            DTOMontura dtoAltaMontura = new DTOMontura();
            try
            {
                dtoAltaMontura.TipoMontura = CUListadoMontura.Ejecutar();
            }
            catch (Exception ex)
            {
                //FALTA EXCEPTION
            }
            return View(dtoAltaMontura);

        }
        

        // POST: MonturaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTOMontura dtoAltaMontura)
        {
          
                dtoAltaMontura.TipoMontura = CUListadoMontura.Ejecutar();

                try
                {
                    CUAltaMontura.Ejecutar(dtoAltaMontura);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {

                    return View(dtoAltaMontura);

                }
            }

        // GET: MonturaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonturaController/Edit/5
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

        // GET: MonturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonturaController/Delete/5
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
