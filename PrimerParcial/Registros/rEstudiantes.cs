using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcial.Entidades;
using PrimerParcial.BLL;
using PrimerParcial.Consultas;

namespace PrimerParcial
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            EstudianteIdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            EdadnumericUpDown.Value = 0;
            CarreratextBox.Text = string.Empty;
        }

        private Estudiantes GetInstance()
        {
            return new Estudiantes(
                NombretextBox.Text,
                (int)EdadnumericUpDown.Value,
                CarreratextBox.Text
                );
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes es = EstudiantesBLL.Buscar((int)EstudianteIdnumericUpDown.Value);
            if (es == null)
            {
                if (EstudiantesBLL.Guardar(GetInstance()))
                    MessageBox.Show("Se guardo el estudiante.");
                else
                    MessageBox.Show("No se guardo el estudiante.");
            }
            else
            {
                es.Nombres = NombretextBox.Text;
                es.Edad = (int)EdadnumericUpDown.Value;
                es.Carrera = CarreratextBox.Text;
             
                if (EstudiantesBLL.Modificar(es))
                    MessageBox.Show("Se a modificado el estudiante");
                else
                    MessageBox.Show("No se pudo modificar el estudiante");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (EstudiantesBLL.Eliminar((int)EstudianteIdnumericUpDown.Value))
                MessageBox.Show("Se a eliminado el estudiante");
            else
                MessageBox.Show("No se pudo eliminar el estudiante");

            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes es = EstudiantesBLL.Buscar((int)EstudianteIdnumericUpDown.Value);
            if (es != null)
            {
                NombretextBox.Text = es.Nombres;
                EdadnumericUpDown.Value = es.Edad;
                CarreratextBox.Text = es.Carrera;
                MontoExoneradotextBox.Text = es.MontoExonerado.ToString();
            }
            else
                MessageBox.Show("Este estudiante no existe");
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            new cEstudiantes().Show();
        }
    }
}
