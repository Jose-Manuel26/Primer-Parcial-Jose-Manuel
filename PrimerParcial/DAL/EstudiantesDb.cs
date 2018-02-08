using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PrimerParcial.Entidades;

namespace PrimerParcial.DAL
{
    public class EstudiantesDb : DbContext
    {

        public EstudiantesDb() : base("ConStr")
        {

        }

        public DbSet<Estudiantes> Estudiante { get; set; }
    }
}
