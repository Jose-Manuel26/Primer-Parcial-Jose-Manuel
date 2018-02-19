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
        //ConStr - para conectar al SQL Server Database file "EstudiantesDb".
        //ConStrServer - para conectar a la base de datos "EstudinateDb" 
        //en el servidor local de SQL Server.
        public EstudiantesDb() : base("ConStrServer")
        {

        }

        public DbSet<Estudiantes> Estudiante { get; set; }
    }
}
