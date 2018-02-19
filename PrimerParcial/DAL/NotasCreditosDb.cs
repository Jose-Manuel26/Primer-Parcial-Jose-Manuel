using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PrimerParcial.Entidades;

namespace PrimerParcial.DAL
{
    public class NotasCreditosDb : DbContext
    {
        //ConStr - para conectar al SQL Server Database file "EstudiantesDb".
        //ConStrServer - para conectar a la base de datos "EstudinateDb" 
        //en el servidor local de SQL Server.
        public NotasCreditosDb() : base("ConStrServer")
        {

        }

        public DbSet<NotasCreditos> NotaCredito { get; set; }
    
    }
}
