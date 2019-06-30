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
    public partial class frmFormaPago : MetroFramework.Forms.MetroForm
    {
        string modo;
        public frmFormaPago()
        {
            InitializeComponent();
        }

        private void frmFormaPago_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
            LimpiarFormulario();
            BloquearFormulario();
            dgvFormaPago.AutoGenerateColumns = true;
        }
        
        private void BloquearFormulario()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void DesbloquearFormulario()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public void ActualizarDgv()
        {
            dgvFormaPago.DataSource = null;
            dgvFormaPago.DataSource = FormaPago.ListarFormaPago();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DesbloquearFormulario();
            LimpiarFormulario();
            modo = "I";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearFormulario();
            txtCodigo.Enabled = false;
            
            modo = "E";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormaPago fp = (FormaPago)dgvFormaPago.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Confirma la eliminacion del registro?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (fp != null)
                {
                    FormaPago.Eliminar(fp);
                }
                ActualizarDgv();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                FormaPago fp = new FormaPago();

                if (txtCodigo != null && txtDescripcion != null)
                {

                    fp.Codigo = txtCodigo.Text;
                    fp.Descripcion = txtDescripcion.Text;
                    FormaPago.Agregar(fp);
                    
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            else if (modo == "E")
            {
                FormaPago fp = new FormaPago();

                int ID = dgvFormaPago.CurrentRow.Index;

                if (ID > -1)
                {
                    fp.Codigo = txtCodigo.Text;
                    fp.Descripcion = txtDescripcion.Text;

                    FormaPago.Editar(fp);
                    MessageBox.Show("Registro Actualizado Correctamente");
                   
                }
            }
            ActualizarDgv();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }
        public void LimpiarFormulario()
        {
            txtCodigo.Text = null;
            txtDescripcion.Text = null;
        }

        private void dgvFormaPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormaPago fp = (FormaPago)dgvFormaPago.CurrentRow.DataBoundItem;
            btnModificar.Enabled = true;
            txtCodigo.Text = fp.Codigo;
            txtDescripcion.Text = fp.Descripcion;
            
        }
    }
}
