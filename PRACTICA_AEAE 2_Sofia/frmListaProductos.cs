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
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarproducto frm = new frmEditarproducto();
            frm.ShowDialog();
        }

        private void dataGridproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridproductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmEditarproducto frm = new frmEditarproducto();
                frm.ShowDialog();
            }
        }
    }
}
