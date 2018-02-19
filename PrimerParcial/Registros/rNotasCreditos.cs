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
            double montoAsignatura = (double)MontoAsignaturanumericUpDown.Value;
            double pctBeca = (double)PctBecanumericUpDown.Value;
            double res = (pctBeca/100) * montoAsignatura; 
            double monto = montoAsignatura + res;

            estudiante = EstudiantesBLL.Buscar((int)EstudianteIdnumericUpDown.Value);
            int estudianteId = (estudiante == null) ? 0 : estudiante.EstudianteId;

            return new NotasCreditos(
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
            NotasCreditos nota = NotasCreditosBLL.Buscar((int)NotaIdnumericUpDown.Value);
            if (nota == null)
            {
                NotasCreditos n = GetNota();

                estudiante.MontoExonerado += n.Monto;
              
                if (NotasCreditosBLL.Guardar(n))
                    MessageBox.Show("Se guardo la nota.");
                else
                    MessageBox.Show("No se guardo la nota.");
            }
            else
            {
                nota.Fecha = FechadateTimePicker.Value;
                nota.EstudianteId = (int)EstudianteIdnumericUpDown.Value;
                nota.Observaciones = ObservacionestextBox.Text;
                nota.MontoAsignaciones = (double)MontoAsignaturanumericUpDown.Value;
                nota.PctBeca = (double)PctBecanumericUpDown.Value;
                double res = (nota.PctBeca / 100) * nota.MontoAsignaciones;
                nota.Monto = nota.MontoAsignaciones + res;
                estudiante.MontoExonerado += nota.Monto;

                if (NotasCreditosBLL.Modificar(nota))
                    MessageBox.Show("Se a modificado la nota");
                else
                    MessageBox.Show("No se pudo modificar la nota");
            }

            EstudiantesBLL.Modificar(estudiante);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (NotasCreditosBLL.Eliminar((int)NotaIdnumericUpDown.Value))
            {
                estudiante.MontoExonerado = 0;
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
