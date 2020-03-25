using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos.Model;
using System.Data.Entity;
using Capa_Objetos.Clases;

namespace Capa_AccesoDatos.Clases
{
    public class ConciertoDAO
    {
        MyBandTourEntities db = new MyBandTourEntities();
        public void crearConcierto(Conciertos concierto)
        {
            try
            {
                var banda = db.Bandas.Find(concierto.IdBanda);
                banda.Conciertos.Add(concierto);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
  
        public void actualizarConcierto(Conciertos concierto)
        {
            try
            {
                db.Entry(concierto).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
