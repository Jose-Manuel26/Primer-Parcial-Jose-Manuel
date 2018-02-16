using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    public class NotasCreditoscs
    {
        [Key]
        public int NotaId { get; set; }
        public string Fecha { get; set; }
        public int EstudianteId { get; set; }
        public string Observaciones { get; set; }
        public float MontoAsignaciones { get; set; }
        public float PctBeca { get; set; }
        public float Monto { get; set; }

        public NotasCreditoscs()
        {
            NotaId = 0;
            Fecha = string.Empty;
            EstudianteId = 0;
            Observaciones = string.Empty;
            MontoAsignaciones = 0;
            PctBeca = 0;
            Monto = 0;
        }

        public NotasCreditoscs(string f, int eid, string o, float ma, float pctb, float m)
        {
            NotaId = 0;
            Fecha = f;
            EstudianteId = eid;
            Observaciones = o;
            MontoAsignaciones = ma;
            PctBeca = pctb;
            Monto = m;
                
        }
    }
}
