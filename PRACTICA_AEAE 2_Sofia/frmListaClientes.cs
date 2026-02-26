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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }
        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++)
            {
                dataGridView1.Rows.Add(
                    i,
                    "Cliente " + i,
                    "Documento " + i,
                    "Telefono " + i
                );
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmEditarCliente frm = new frmEditarCliente();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente frm = new frmEditarCliente();
            frm.ShowDialog();
        }
    }
}
