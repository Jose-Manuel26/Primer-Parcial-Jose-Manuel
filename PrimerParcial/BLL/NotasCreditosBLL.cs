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
        public static bool Guardar(NotasCreditos nota)
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

        public static bool Modificar(NotasCreditos nota)
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
                NotasCreditos nota = db.NotaCredito.Find(id);
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

        public static NotasCreditos Buscar(int id)
        {
            NotasCreditos nota = null;
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

        public static List<NotasCreditos> GetList(Expression<Func<NotasCreditos, bool>> filter)
        {
            List<NotasCreditos> us = null;

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
