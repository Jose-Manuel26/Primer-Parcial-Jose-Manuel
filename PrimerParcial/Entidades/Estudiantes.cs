using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public double MontoExonerado { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Nombres = string.Empty;
            Edad = 0;
            Carrera = string.Empty;
            MontoExonerado = 0;
        }

        public Estudiantes(string nombres, int edad, string carrera)
        {
            this.Nombres = nombres;
            this.Edad = edad;
            this.Carrera = carrera;
            MontoExonerado = 0;
        }
    }
}
