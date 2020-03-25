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
    public class BandasRestController : Controller
    {
        BandaLN bandaLN = new BandaLN();

        [HttpGet]
        public JsonResult obtenerBandas()
        {
            ObjetoRetorno response = bandaLN.obtenerBandas();

            return new JsonResult
            {
                Data = response,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpGet]
        public JsonResult obtenerBandaPorId(int id)
        {
            ObjetoRetorno response = bandaLN.obtenerBandaPorId(id);

            return new JsonResult
            {
                Data = response,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPost]
        public JsonResult crearBanda(Bandas banda)
        {
            ObjetoRetorno response = bandaLN.crearBanda(banda);

            return new JsonResult
            {
                Data = response
            };
        }

        [HttpPut]
        public JsonResult actualizarBanda(Bandas banda)
        {
            ObjetoRetorno response = bandaLN.actualizarBanda(banda);

            return new JsonResult
            {
                Data = response
            };
        }
    }
}