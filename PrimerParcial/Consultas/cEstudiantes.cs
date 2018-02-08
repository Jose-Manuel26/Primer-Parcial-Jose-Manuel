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
using System.Linq.Expressions;

namespace PrimerParcial.Consultas
{
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Estudiantes, bool>> filter = x => true;
            int dato = 0;

            switch (DatoscomboBox.SelectedIndex)
            {
                case 0: //Estudiante
                    dato = int.Parse(FiltrartextBox.Text);
                    filter = x => x.Matricula == dato;
                    break;

                case 1: //Nombre
                    filter = x => x.Nombres.Contains(FiltrartextBox.Text);
                    break;

                case 2: //Edad
                    dato = int.Parse(FiltrartextBox.Text);
                    filter = x => x.Edad == dato;
                    break;

                case 3: //Carrera
                    filter = x => x.Carrera.Contains(FiltrartextBox.Text);
                    break;
            }

            EstudinatesdataGridView.DataSource = EstudiantesBLL.GetList(filter);
        }
    }
}
