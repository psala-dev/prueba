using DTOs.DTOsUsuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        private string urlLogin = "";
        private string urlAlta = "";
        private string urlRoles = "";

        public UsuarioController(IConfiguration configuration)
        {
            string urlBase = configuration.GetValue<string>("urlBase");
            urlLogin = urlBase + "Usuario/Login";
            urlAlta = urlBase + "Usuario/Alta";
            urlRoles = urlBase + "Usuario/Roles";
        }
        //GET: UsuarioController/Login
        public ActionResult Login()
        {
            return View();
        }

        //POST: UsuarioController/Login
        [HttpPost]
        public ActionResult Login(DTOLogin dtoLogin)
        {
            try
            {
                HttpClient client = new HttpClient();
                string json = JsonConvert.SerializeObject(dtoLogin);
                StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> tarea = client.PostAsync(urlLogin, contenido);
                tarea.Wait();
                HttpResponseMessage respuesta = tarea.Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    string datos = respuesta.Content.ReadAsStringAsync().Result;
                    DTOLoginResponse dtoLoginResponse = JsonConvert.DeserializeObject<DTOLoginResponse>(datos);

                    HttpContext.Session.SetString("Email", dtoLoginResponse.Email);
                    //guardo el rol para mostrar o no ciertas cosas en la vista
                    HttpContext.Session.SetString("Rol", dtoLoginResponse.Rol);
                    HttpContext.Session.SetInt32("Id", dtoLoginResponse.Id);
                    HttpContext.Session.SetString("Token", dtoLoginResponse.Token);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    string error = respuesta.Content.ReadAsStringAsync().Result;
                    ViewBag.Error = error;
                    return View(dtoLogin);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(dtoLogin);
            }
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            DTOAltaUsuario dtoAltaUsuario = new DTOAltaUsuario();
            try
            {
                HttpClient client = new HttpClient();
                Task<HttpResponseMessage> tarea = client.GetAsync(urlRoles);
                tarea.Wait();
                HttpResponseMessage respuesta = tarea.Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    string datos = respuesta.Content.ReadAsStringAsync().Result;
                    dtoAltaUsuario.Roles = (string[])JsonConvert.DeserializeObject<IEnumerable<string>>(datos);
                }
                else
                {
                    string error = respuesta.Content.ReadAsStringAsync().Result;
                    ViewBag.Error = error;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(dtoAltaUsuario);
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTOAltaUsuario dtoAltaUsuario)
        {
            try
            {
                //Recarga roles
                HttpClient clientRoles = new HttpClient();
                string datosRoles = clientRoles.GetAsync(urlRoles).Result.Content.ReadAsStringAsync().Result;
                dtoAltaUsuario.Roles = (string[])JsonConvert.DeserializeObject<IEnumerable<string>>(datosRoles);

                //Alta
                HttpClient client = new HttpClient();
                string json = JsonConvert.SerializeObject(dtoAltaUsuario);
                StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");

                Task<HttpResponseMessage> tarea = client.PostAsync(urlAlta, contenido);
                tarea.Wait();
                HttpResponseMessage respuesta = tarea.Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    string error = respuesta.Content.ReadAsStringAsync().Result;
                    ViewBag.Error = error;
                    return View(dtoAltaUsuario);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(dtoAltaUsuario);
            }
        }
    }

}
