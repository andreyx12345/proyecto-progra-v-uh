using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos.Clases;
using Capa_AccesoDatos.Model;
using Capa_Objetos.Clases;

namespace Capa_LogicaNegocios.Clases
{
    public class BandaLN
    {
        BandaDAO bandaDAO = new BandaDAO();
        public ObjetoRetorno obtenerBandas()
        {
            ObjetoRetorno response = new ObjetoRetorno();

            try
            {
                var respuesta = bandaDAO.obtenerBandas();
                response.CodigoRespuesta = 1;
                response.MensajeRespuesta = "ok";
                response.ObjetoRespuesta = respuesta;

            } catch (Exception e)
            {
                response.CodigoRespuesta = -1;
                response.MensajeRespuesta = e.Message;
            }

            return response;
        }

        public ObjetoRetorno crearBanda(Bandas banda)
        {
            ObjetoRetorno response = new ObjetoRetorno();

            try
            {
                bandaDAO.crearBanda(banda);
                response.CodigoRespuesta = 1;
                response.MensajeRespuesta = "Guardado exitosamente";
            }
            catch (Exception e)
            {
                response.CodigoRespuesta = -1;
                response.MensajeRespuesta = e.Message;
            }

            return response;
        }

        public ObjetoRetorno actualizarBanda(Bandas banda)
        {
            ObjetoRetorno response = new ObjetoRetorno();

            try
            {
                bandaDAO.actualizarBanda(banda);
                response.CodigoRespuesta = 1;
                response.MensajeRespuesta = "ok";
            }
            catch (Exception e)
            {
                response.CodigoRespuesta = -1;
                response.MensajeRespuesta = e.Message;
            }

            return response;
        }

        public ObjetoRetorno obtenerBandaPorId(int id)
        {
            ObjetoRetorno response = new ObjetoRetorno();

            try
            {
                var respuesta = bandaDAO.obtenerBandaPorId(id);
                response.CodigoRespuesta = 1;
                response.MensajeRespuesta = "ok";
                response.ObjetoRespuesta = respuesta;

            }
            catch (Exception e)
            {
                response.CodigoRespuesta = -1;
                response.MensajeRespuesta = e.Message;
            }

            return response;
        }
    }
}