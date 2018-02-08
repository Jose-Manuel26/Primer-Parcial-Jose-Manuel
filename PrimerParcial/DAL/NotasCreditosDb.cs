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

        public NotasCreditosDb() : base("ConStr")
        {

        }

        public DbSet<NotasCreditoscs> NotaCredito { get; set; }
    
    }
}
