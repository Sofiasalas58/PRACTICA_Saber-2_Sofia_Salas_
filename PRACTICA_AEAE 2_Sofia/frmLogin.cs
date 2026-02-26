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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string Respuesta = "";

            if (txtUsuario.Text != "" && txtPasword.Text != "")
            {
            
                if (txtUsuario.Text == "admin" && txtPasword.Text == "123")
                    Respuesta = "SOFIA SALAS";
            }

            if (Respuesta != "")
            {
                MessageBox.Show("Bienvenido: " + Respuesta);
                frmPrincipal frmppal = new frmPrincipal();
                this.Hide();
                frmppal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
