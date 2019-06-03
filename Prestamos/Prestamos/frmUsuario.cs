using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class frmUsuario : MetroFramework.Forms.MetroForm
    {
        string modo;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DesbloquearFormulario();
            modo = "I";
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearFormulario();
            txtCodigo.Enabled = false;
            modo = "E";
        }

        

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.AutoGenerateColumns = true;
            LimpiarFormulario();
            BloquearFormulario();
           if (Usuario.ObtenerUsuarios() != null) ActualizarDgv();
        }

        private void BloquearFormulario()
        {
            txtClave.Enabled = false;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            
        }

        private void DesbloquearFormulario()
        {
            txtClave.Enabled = true;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = null;
            txtCodigo.Text = null;
            txtClave.Text = null;
        }
        private void ActualizarDgv()
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = Usuario.ObtenerUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                if (txtCodigo.Text != null && txtNombre.Text != null && txtClave.Text != null)
                {
                    Usuario usuario = new Usuario();
                    usuario.Codigo = txtCodigo.Text;
                    usuario.Clave = txtClave.Text;
                    usuario.Nombre = txtNombre.Text;

                    Usuario.Agregar(usuario);
                    ActualizarDgv();
                    LimpiarFormulario();
                    BloquearFormulario();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
                
            }else if (modo == "E")
            {
                Usuario usuario = new Usuario();
                int id = dgvUsuario.CurrentRow.Index;

                if (id > -1)
                {
                    usuario.Codigo = txtCodigo.Text;
                    usuario.Clave = txtClave.Text;
                    usuario.Nombre = txtNombre.Text;

                    Usuario.Editar(id, usuario);
                    ActualizarDgv();
                    BloquearFormulario();
                    MessageBox.Show("Registro Actualizado Correctamente");
                    LimpiarFormulario();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuario = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
            BloquearFormulario();

            txtNombre.Text = usuario.Nombre;
            txtCodigo.Text = usuario.Codigo;
            txtClave.Text = usuario.Clave;

        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
