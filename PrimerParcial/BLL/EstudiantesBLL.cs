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
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool flag = false;

            try
            {
                EstudiantesDb db = new EstudiantesDb();
                db.Estudiante.Add(estudiante);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static bool Modificar(Estudiantes estudiante)
        {
            bool flag = false;

            try
            {
                EstudiantesDb db = new EstudiantesDb();
                db.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
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
                EstudiantesDb db = new EstudiantesDb();
                Estudiantes es = db.Estudiante.Find(id);
                db.Estudiante.Remove(es);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Estudiantes Buscar(int id)
        {
            Estudiantes es = null;
            try
            {
                EstudiantesDb db = new EstudiantesDb();
                es = db.Estudiante.Find(id);
            }
            catch (Exception)
            {
                throw;
            }

            return es;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> filter)
        {
            List<Estudiantes> us = null;

            try
            {
                EstudiantesDb db = new EstudiantesDb();
                us = db.Estudiante.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }

            return us;
        }
    }
}
