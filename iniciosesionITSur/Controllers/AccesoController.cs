using ConexionDB;
using Microsoft.AspNetCore.Mvc;

namespace iniciosesionITSur.Controllers
{
    public class AccesoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string UserId, string Contrasenia)
        {
            Usuarios usuarios = new Usuarios().encontrarUsuario(UserId, Contrasenia);
        }
    }
}
