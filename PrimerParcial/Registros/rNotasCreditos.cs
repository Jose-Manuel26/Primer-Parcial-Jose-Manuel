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

namespace PrimerParcial.Registros
{
    public partial class rNotasCreditos : Form
    {
        public rNotasCreditos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            NotaIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            EstudianteId2numericUpDown.Value = 0;
            ObservacionestextBox.Text = string.Empty;
            MontoAsignaturastextBox.Text = string.Empty;
            PtcBecatextBox.Text = string.Empty;
            MontotextBox.Text = string.Empty;
        }

        private NotasCreditoscs GetNota()
        {
            float ma = int.Parse(MontoAsignaturastextBox.Text);
            float pct = int.Parse(PtcBecatextBox.Text);
            float m = ma * pct;

            Estudiantes es = EstudiantesBLL.Buscar((int)EstudianteId2numericUpDown.Value);
            int n = (es == null) ? 0 : es.Matricula;

            return new NotasCreditoscs(
                FechadateTimePicker.Value.ToString(),
                n,
                ObservacionestextBox.Text,
                ma,
                pct,
                m
                );
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            NotasCreditoscs nota = NotasCreditosBLL.Buscar((int)NotaIdnumericUpDown.Value);
            if (nota == null)
            {
                if (NotasCreditosBLL.Guardar(GetNota()))
                    MessageBox.Show("Se guardo la nota.");
                else
                    MessageBox.Show("No se guardo la nota.");
            }
            else
            {

                nota.Fecha = FechadateTimePicker.Value.ToString();
                nota.EstudianteId = (int)EstudianteId2numericUpDown.Value;
                nota.Observaciones = ObservacionestextBox.Text;
                nota.MontoAsignaciones = float.Parse(MontoAsignaturastextBox.Text);
                nota.PctBeca = float.Parse(PtcBecatextBox.Text);
                nota.Monto = float.Parse(MontoAsignaturastextBox.Text) * float.Parse(PtcBecatextBox.Text);

                if (NotasCreditosBLL.Modificar(nota))
                    MessageBox.Show("Se a modificado la nota");
                else
                    MessageBox.Show("No se pudo modificar la nota");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (NotasCreditosBLL.Eliminar((int)NotaIdnumericUpDown.Value))
                MessageBox.Show("Se a eliminado la nota");
            else
                MessageBox.Show("No se pudo eliminar la nota");

            Limpiar();

        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            new cNotasCreditos().Show();
        }

        private void rNotasCreditos_Load(object sender, EventArgs e)
        {

        }

        private void BuscarEsIdbutton_Click(object sender, EventArgs e)
        {
            Estudiantes es = EstudiantesBLL.Buscar((int)EstudianteId2numericUpDown.Value);
            if (es != null)
            {
                EstudianteId2numericUpDown.Value = es.Matricula;
                EsNombretextBox.Text = es.Nombres;
            }
            else
                MessageBox.Show("Este estudiante no existe");
        }

        private void BuscarNotaIdbutton_Click(object sender, EventArgs e)
        {
            NotasCreditoscs nota = NotasCreditosBLL.Buscar((int)NotaIdnumericUpDown.Value);
            if (nota != null)
            {
                NotaIdnumericUpDown.Value = nota.NotaId;
                FechadateTimePicker.Value = DateTime.Parse(nota.Fecha);
                EstudianteId2numericUpDown.Value = nota.EstudianteId;
                ObservacionestextBox.Text = nota.Observaciones;
                MontoAsignaturastextBox.Text = nota.MontoAsignaciones.ToString();
                PtcBecatextBox.Text = nota.PctBeca.ToString();
                MontotextBox.Text = nota.Monto.ToString();
            }
            else
                MessageBox.Show("Este estudiante no existe");
        }

        private void MontotextBox_TextChanged(object sender, EventArgs e)
        {
            if(MontoAsignaturastextBox.Text != string.Empty && 
                PtcBecatextBox.Text != string.Empty)
                MontotextBox.Text = (float.Parse(MontoAsignaturastextBox.Text) * float.Parse(PtcBecatextBox.Text)).ToString();
        }
    }
}
