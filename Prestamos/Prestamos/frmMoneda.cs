using System;
using BibliotecaClases;
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
    public partial class frmMoneda : MetroFramework.Forms.MetroForm
    {
        Moneda moneda;
        string modo;
        public frmMoneda()
        {
            InitializeComponent();
        }

        private void frmMoneda_Load(object sender, EventArgs e)
        {
            moneda = new Moneda();
            dtgDetalleMoneda.AutoGenerateColumns = true;
            BloquearFormulario();

            if (Moneda.ListarMoneda() != null)
            {
                ActualizarDataGrid();
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DesbloquearFormulario();
            Limpiar();
            modo = "i";
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleMoneda.DataSource = null;
            dtgDetalleMoneda.DataSource = Moneda.ListarMoneda();
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPais.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Moneda md = (Moneda)dtgDetalleMoneda.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Confirma la eliminacion del registro?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (md != null)
                {
                    Moneda.Eliminar(md);
                }
                ActualizarDataGrid();
            }
        }

        private void dtgDetalleMoneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Moneda m = (Moneda)dtgDetalleMoneda.CurrentRow.DataBoundItem;
            btnModificar.Enabled = true;
            txtCodigo.Text = m.Codigo;
            txtDescripcion.Text = m.Descripcion;
            txtPais.Text = m.PaisProcedencia;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = "E";
           DesbloquearFormulario();
            txtCodigo.Enabled = false;
        }

        private void BloquearFormulario()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPais.Enabled = false;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void DesbloquearFormulario()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPais.Enabled = true;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "i")
            {
                Moneda md = new Moneda();

                if (txtCodigo != null && txtDescripcion != null && txtPais != null)
                {

                    //MonedaDetalle md = new MonedaDetalle();
                    md.PaisProcedencia = txtPais.Text;
                    md.Codigo = txtCodigo.Text;
                    md.Descripcion = txtDescripcion.Text;

                    Moneda.Agregar(md);
                    //moneda.detalle_moneda.Add(md);

                    ActualizarDataGrid();
                    Limpiar();
                    BloquearFormulario();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }else if (modo == "E")
            {
                Moneda md = new Moneda();

                int MonedaID = dtgDetalleMoneda.CurrentRow.Index;

                if (MonedaID > -1)
                {
                    md.Codigo = txtCodigo.Text;
                    md.Descripcion = txtDescripcion.Text;
                    md.PaisProcedencia = txtPais.Text;

                    Moneda.EditarMoneda(MonedaID, md);
                    ActualizarDataGrid();
                    BloquearFormulario();
                    MessageBox.Show("Registro Actualizado Correctamente");

                }
            }
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BloquearFormulario();
            
        }
    }
}
