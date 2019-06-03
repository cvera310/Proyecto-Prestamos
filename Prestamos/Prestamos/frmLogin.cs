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
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT * FROM usuario WHERE usu_codigo='" + txtUsuario.Text + "' AND usu_clave='" + txtClave.Text + "'";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlDataReader lectordedatos = cmd.ExecuteReader();

                if (lectordedatos.Read())
                {
                    string ActualizarUltAcceso = "UPDATE usuario SET usu_ultacceso='"+System.DateTime.Now+"' WHERE usu_codigo='"+txtUsuario.Text+"'";
                    SqlCommand update = new SqlCommand(ActualizarUltAcceso, con);
                    update.ExecuteNonQuery();
                    //Console.WriteLine(ActualizarUltAcceso);

                    LoginUsuario lu = new LoginUsuario();
                    lu.usuario = txtUsuario.Text;
                    LoginUsuario.Agregar(lu);
                    
                 
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecto");
                }

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            if (!VerifyConnection())
            {
                MessageBox.Show("No se pudo establecer la conexion con el servidor");
                this.Close();
            }
            
        }
        public bool VerifyConnection()
        {
            SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION);
           try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
