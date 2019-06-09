using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Usuario.Acceder(txtUsuario.Text, txtClave.Text))
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            if (!SqlServer.VerifyConnection())
            {
                MessageBox.Show("No se pudo establecer la conexion con el servidor");
                this.Close();
            }
            
        }
        
    }
}
