using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    public class NotasCreditos
    {
        [Key]
        public int NotaId { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteId { get; set; }
        public double MontoAsignaciones { get; set; }
        public double PctBeca { get; set; }
        public double Monto { get; set; }
        public string Observaciones { get; set; }

        public NotasCreditos()
        {
            NotaId = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Observaciones = string.Empty;
            MontoAsignaciones = 0;
            PctBeca = 0;
            Monto = 0;
        }

        public NotasCreditos(int n,DateTime f, int eid, double ma, double pctb, double m, string o)
        {
            NotaId = n;
            Fecha = f;
            EstudianteId = eid;
            Observaciones = o;
            MontoAsignaciones = ma;
            PctBeca = pctb;
            Monto = m;
                
        }
    }
}
