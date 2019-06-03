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
    public partial class frmTipoPrestamo : MetroFramework.Forms.MetroForm
    {
        string modo;
        public frmTipoPrestamo()
        {
            InitializeComponent();
        }

        private void frmTipoPrestamo_Load(object sender, EventArgs e)
        {
            
            dgvTipoPrestamo.AutoGenerateColumns = true;
            BloquearFormulario();
            if (TipoPrestamo.ObtenerTipoPrestamos() != null)
            {
                ActualizarDgv();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            DesbloquearFormulario();
            LimpiarFormulario();
            modo = "I";
        }
       
        private void ActualizarDgv()
        {
            dgvTipoPrestamo.DataSource = null;
            dgvTipoPrestamo.DataSource = TipoPrestamo.ObtenerTipoPrestamos();
        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = null;
            txtDescripcion.Text = null;
            txtInteres.Text = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearFormulario();
            txtCodigo.Enabled = false;
            modo = "E";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma la eliminacion del registro?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                TipoPrestamo tp = new TipoPrestamo();
                tp = (TipoPrestamo)dgvTipoPrestamo.CurrentRow.DataBoundItem;
                if (tp != null)
                {
                    TipoPrestamo.Eliminar(tp);
                }
                ActualizarDgv();
            }
        }

        private void dgvTipoPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TipoPrestamo tp = (TipoPrestamo)dgvTipoPrestamo.CurrentRow.DataBoundItem;
            BloquearFormulario();
           
            txtCodigo.Text = tp.Codigo;
            txtDescripcion.Text = tp.Descripcion;
            txtInteres.Text = Convert.ToString(tp.InteresBase);

        }

        public void BloquearFormulario()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtInteres.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        public void DesbloquearFormulario()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtInteres.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
               {
                      e.Handled = false;
               }
                else if (Char.IsControl(e.KeyChar))
               {
                e.Handled = false;
               }
                else if (Char.IsSeparator(e.KeyChar))
               {
                e.Handled = false;
               }
                 else
                {
                    e.Handled = true;
                }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                TipoPrestamo tp = new TipoPrestamo();
                if (txtCodigo != null && txtDescripcion != null && txtInteres != null)
                {
                    tp.Codigo = txtCodigo.Text;
                    tp.Descripcion = txtDescripcion.Text;
                    tp.InteresBase = Convert.ToInt32(txtInteres.Text);
                    TipoPrestamo.Agregar(tp);

                    ActualizarDgv();
                    
                    LimpiarFormulario();


                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos");
                }
            }
            else if (modo == "E")
            {
                TipoPrestamo tp = new TipoPrestamo();

                int TipoPrestamoId = dgvTipoPrestamo.CurrentRow.Index;

                if (TipoPrestamoId > -1)
                {
                    tp.Codigo = txtCodigo.Text;
                    tp.Descripcion = txtDescripcion.Text;
                    tp.InteresBase = Convert.ToInt32(txtInteres.Text);

                    TipoPrestamo.EditarTipoPrestamo(TipoPrestamoId, tp);
                    
                    ActualizarDgv();
                    BloquearFormulario();
                    MessageBox.Show("Registro Actualizado Correctamente");

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}
