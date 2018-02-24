using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;
using PrimerParcial.DAL;
using System.Linq.Expressions;
using PrimerParcial.Registros;

namespace PrimerParcial.BLL
{
    public class NotasCreditosBLL
    {
        public static bool Guardar(NotasCreditos nota, Estudiantes estudiante)
        {
            bool flag = false;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();

                estudiante.MontoExonerado += nota.Monto;
                EstudiantesBLL.Modificar(estudiante);
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

        public static bool Modificar(NotasCreditos nota, Estudiantes estudiante)
        {
            bool flag = false;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();

                estudiante.MontoExonerado += rNotasCreditos.DIFERENCIA;
                EstudiantesBLL.Modificar(estudiante);
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
            List<NotasCreditos> list = null;

            try
            {
                NotasCreditosDb db = new NotasCreditosDb();
                list = db.NotaCredito.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }
    }
}
