using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmEditaEmpleados frm = new frmEditaEmpleados();
                frm.ShowDialog();
            }
        }
    }
}
