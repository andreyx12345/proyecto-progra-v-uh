using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_LogicaNegocios.Clases;
using Capa_Objetos.Clases;
using Capa_AccesoDatos.Model;

namespace Capa_InterfazUsuario.Controllers
{
    public class HomeController : Controller
    {
        BandaLN bandaLN = new BandaLN();
        public ActionResult Index()
        {
            return View();
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
    }
}