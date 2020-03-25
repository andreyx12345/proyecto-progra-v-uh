using System;
using System.Collections.Generic;
using System.Linq;
using Capa_AccesoDatos.Model;
using System.Data.Entity;

namespace Capa_AccesoDatos.Clases
{
    public class BandaDAO
    {
        MyBandTourEntities db = new MyBandTourEntities();

        public List<Bandas> obtenerBandas ()
        {
            List<Bandas> bandas = new List<Bandas>();
            try
            {
                bandas = db.Bandas.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

            return bandas;
        }

        public Bandas obtenerBandaPorId(int id)
        {
            Bandas bandas = new Bandas();
            try
            {
                bandas = db.Bandas.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return bandas;
        }

        public void crearBanda(Bandas banda)
        {
            try
            {
                db.Bandas.Add(banda);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void actualizarBanda(Bandas banda)
        {
            try
            {
                db.Entry(banda).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}