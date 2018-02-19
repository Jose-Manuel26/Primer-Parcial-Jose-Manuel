using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcial.Entidades;
using PrimerParcial.BLL;

namespace PrimerParcial.Consultas
{
    public partial class cNotasCreditos : Form
    {
        public cNotasCreditos()
        {
            InitializeComponent();
        }

        private void ImprimirNotabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<NotasCreditos, bool>> filter = x => true;
            int dato = 0;

            switch (DatoNotacomboBox.SelectedIndex)
            {
                case 0: //NotaId
                    dato = int.Parse(ImprimirNotatextBox.Text);
                    filter = x => x.NotaId == dato;
                    break;
                   
                case 1: //Fecha
                    DateTime date = DateTime.Parse(ImprimirNotatextBox.Text);
                    filter = x => x.Fecha.Date == date.Date;
                    break;

                case 2: //EstudinateId
                    dato = int.Parse(ImprimirNotatextBox.Text);
                    filter = x => x.EstudianteId == dato;
                    break;

                case 3: //Obeservacione
                    filter = x => x.Observaciones.Contains(ImprimirNotatextBox.Text);
                    break;

                case 4: //Monto Asignaturas
                    float.Parse(ImprimirNotatextBox.Text);
                    filter = x => x.MontoAsignaciones == dato;
                    break;

                case 5: //PctBeca
                    float.Parse(ImprimirNotatextBox.Text);
                    filter = x => x.PctBeca == dato;
                    break;

                case 6: //Monto
                    float.Parse(ImprimirNotatextBox.Text);
                    filter = x => x.Monto == dato;
                    break;
            }

            NotasdataGridView.DataSource = NotasCreditosBLL.GetList(filter);
        }
    }
}
