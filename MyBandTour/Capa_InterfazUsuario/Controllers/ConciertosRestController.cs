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
    public class ConciertosRestController : Controller
    {
        ConciertoLN conciertoLN = new ConciertoLN();

        [HttpPost]
        public JsonResult crearConcierto(Conciertos concierto)
        {
            ObjetoRetorno response = conciertoLN.crearConcierto(concierto);

            return new JsonResult
            {
                Data = response
            };
        }

        [HttpPut]
        public JsonResult actualizarConcierto(Conciertos concierto)
        {
            ObjetoRetorno response = conciertoLN.actualizarConcierto(concierto);

            return new JsonResult
            {
                Data = response
            };
        }
    }
}