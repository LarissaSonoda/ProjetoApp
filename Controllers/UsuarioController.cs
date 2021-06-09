using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoApp.Models;


namespace ProjetoApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var usuario = new Usuario(); //criando OBJETO para a CLASSE
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if (ModelState.IsValid) //verificar requisição
            {
                return View("Resultado", usuario); //return pra view resultado
            }
            return View(usuario);
        }
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Lari",
                "Ana"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()),
                JsonRequestBehavior.AllowGet);
        }
    }
}