using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;
using PrimerParcial.DAL;
using System.Linq.Expressions;

namespace PrimerParcial.BLL
{
    public class NotasCreditosBLL
    {
        public static bool Guardar(NotasCreditoscs nota)
        {
            bool flag = false;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();
                db.NotaCredito.Add(nota);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static bool Modificar(NotasCreditoscs nota)
        {
            bool flag = false;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();
                db.Entry(nota).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static bool Eliminar(int id)
        {
            bool flag = false;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();
                NotasCreditoscs nota = db.NotaCredito.Find(id);
                db.NotaCredito.Remove(nota);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static NotasCreditoscs Buscar(int id)
        {
            NotasCreditoscs nota = null;
            try
            {
                NotasCreditosDb db = new NotasCreditosDb();
                nota = db.NotaCredito.Find(id);
            }
            catch (Exception)
            {
                throw;
            }

            return nota;
        }

        public static List<NotasCreditoscs> GetList(Expression<Func<NotasCreditoscs, bool>> filter)
        {
            List<NotasCreditoscs> us = null;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();
                us = db.NotaCredito.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }

            return us;
        }
    }
}
