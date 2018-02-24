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
        private Estudiantes estudiante;
        public static double DIFERENCIA;//Almacena la diferencia entre monto actual y el anterior

        public rNotasCreditos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            NotaIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            EstudianteIdnumericUpDown.Value = 0;
            ObservacionestextBox.Text = string.Empty;
            MontoAsignaturanumericUpDown.Value = 0;
            PctBecanumericUpDown.Value = 0;
            MontotextBox.Text = string.Empty;
            EstudianteNombretextBox.Text = string.Empty;
        }

        private NotasCreditos GetNota()
        {
            int notaId = (NotaIdnumericUpDown.Value == 0) ? 0 : (int)NotaIdnumericUpDown.Value;
            double montoAsignatura = (double)MontoAsignaturanumericUpDown.Value;
            double pctBeca = (double)PctBecanumericUpDown.Value;
            double res = (pctBeca/100) * montoAsignatura; 
            double monto = montoAsignatura + res;

            int estudianteId = (estudiante == null) ? 0 : estudiante.EstudianteId;

            return new NotasCreditos(
                notaId,
                FechadateTimePicker.Value,
                estudianteId,             
                montoAsignatura,
                pctBeca,
                monto,
                ObservacionestextBox.Text
                );
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            NotasCreditos n = GetNota();
            int a = 0;
            NotasCreditos nota = NotasCreditosBLL.Buscar((int)NotaIdnumericUpDown.Value);
            if (nota == null)
            {                       
                if (NotasCreditosBLL.Guardar(n, estudiante))
                    MessageBox.Show("Se guardo la nota.");
                else
                    MessageBox.Show("No se guardo la nota.");
            }
            else
            {              
                DIFERENCIA = n.Monto - nota.Monto;

                if (NotasCreditosBLL.Modificar(n, estudiante))
                    MessageBox.Show("Se a modificado la nota");
                else
                    MessageBox.Show("No se pudo modificar la nota");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            NotasCreditos nota = NotasCreditosBLL.Buscar((int)NotaIdnumericUpDown.Value);
            if (NotasCreditosBLL.Eliminar(nota.NotaId))
            {
                estudiante.MontoExonerado -= nota.Monto;
                EstudiantesBLL.Modificar(estudiante);
                MessageBox.Show("Se a eliminado la nota");

            }
            else
                MessageBox.Show("No se pudo eliminar la nota");

            Limpiar();

        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            new cNotasCreditos().Show();
        }


        private void BuscarEstudianteIdbutton_Click(object sender, EventArgs e)
        {
            estudiante = EstudiantesBLL.Buscar((int)EstudianteIdnumericUpDown.Value);
            if (estudiante != null)
            {
                EstudianteIdnumericUpDown.Value = estudiante.EstudianteId;
                EstudianteNombretextBox.Text = estudiante.Nombres;
            }
            else
                MessageBox.Show("Este estudiante no existe");
        }

        private void BuscarNotaIdbutton_Click(object sender, EventArgs e)
        {
            NotasCreditos nota = NotasCreditosBLL.Buscar((int)NotaIdnumericUpDown.Value);
            if (nota != null)
            {
                estudiante = EstudiantesBLL.Buscar(nota.EstudianteId);

                NotaIdnumericUpDown.Value = nota.NotaId;
                FechadateTimePicker.Value = nota.Fecha;
                EstudianteIdnumericUpDown.Value = estudiante.EstudianteId;
                EstudianteNombretextBox.Text = estudiante.Nombres;
                ObservacionestextBox.Text = nota.Observaciones;
                MontoAsignaturanumericUpDown.Value = (Decimal)nota.MontoAsignaciones;
                PctBecanumericUpDown.Value = (Decimal)nota.PctBeca;
                MontotextBox.Text = nota.Monto.ToString();
            }
            else
                MessageBox.Show("Este credito no existe");
        }

        private void MontoAsignaturanumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PctBecanumericUpDown.Value != 0)
            {
                MontotextBox.Text = ( MontoAsignaturanumericUpDown.Value + 
                    (MontoAsignaturanumericUpDown.Value * (PctBecanumericUpDown.Value / 100))).ToString();
            }
        }

        private void PctBecanumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MontoAsignaturanumericUpDown.Value != 0)
            {
                MontotextBox.Text = (
                    MontoAsignaturanumericUpDown.Value + (
                    MontoAsignaturanumericUpDown.Value * (PctBecanumericUpDown.Value / 100)
                    )).ToString();
            }
        }
    }
}
