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
    public class ConciertoLN
    {
        ConciertoDAO conciertoDAO = new ConciertoDAO();
        public ObjetoRetorno crearConcierto(Conciertos concierto)
        {
            ObjetoRetorno response = new ObjetoRetorno();

            try
            {
                conciertoDAO.crearConcierto(concierto);
                // Si no hubo una excepcion, el guardado fue exitoso
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

        public ObjetoRetorno actualizarConcierto(Conciertos concierto)
        {
            ObjetoRetorno response = new ObjetoRetorno();

            try
            {
                conciertoDAO.actualizarConcierto(concierto);
                // Si no hubo una excepcion, el guardado fue exitoso
                response.CodigoRespuesta = 1;
                response.MensajeRespuesta = "Actualizado exitosamente";
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
