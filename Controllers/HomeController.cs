using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using ProjetoApp.Models;
using System.Web.Mvc;

namespace ProjetoApp.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Larissa",
                "Ana clara"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()),
                JsonRequestBehavior.AllowGet);
        } 
    }
}