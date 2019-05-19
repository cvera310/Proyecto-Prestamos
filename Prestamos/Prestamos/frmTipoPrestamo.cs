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
    public partial class frmTipoPrestamo : Form
    {
        public frmTipoPrestamo()
        {
            InitializeComponent();
        }

        private void frmTipoPrestamo_Load(object sender, EventArgs e)
        {
            BibliotecaClases.Cliente cliente = new BibliotecaClases.Cliente();
            dgvTipoPrestamo.AutoGenerateColumns = true;

            if (TipoPrestamo.ObtenerTipoPrestamo() != null)
            {
                ActualizarDgv();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoPrestamo tp = new TipoPrestamo();
            if (txtCodigo != null && txtDescripcion != null && txtInteres != null)
            {
                tp.Codigo = txtCodigo.Text;
                tp.Descripcion = txtDescripcion.Text;
                tp.InteresBase = Convert.ToDouble(txtInteres.Text);
                TipoPrestamo.Agregar(tp);

                ActualizarDgv();
                LimpiarFormulario();


            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
            }
        }

        private void ActualizarDgv()
        {
            dgvTipoPrestamo.DataSource = null;
            dgvTipoPrestamo.DataSource = TipoPrestamo.ObtenerTipoPrestamo();
        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = null;
            txtDescripcion.Text = null;
            txtInteres.Text = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TipoPrestamo tp = new TipoPrestamo();

            int TipoPrestamoId = dgvTipoPrestamo.CurrentRow.Index;

            if (TipoPrestamoId > -1)
            {
                tp.Codigo = txtCodigo.Text;
                tp.Descripcion = txtDescripcion.Text;
                tp.InteresBase = Convert.ToDouble(txtInteres.Text);

                TipoPrestamo.ListaTipoPrestamo[TipoPrestamoId] = tp;
                ActualizarDgv();
                MessageBox.Show("Actualizado correctamente");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TipoPrestamo tp = new TipoPrestamo();
            tp = (TipoPrestamo)dgvTipoPrestamo.CurrentRow.DataBoundItem;
            if (tp != null)
            {
                TipoPrestamo.ListaTipoPrestamo.Remove(tp);
            }
            ActualizarDgv();
        }

        private void dgvTipoPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TipoPrestamo tp = (TipoPrestamo)dgvTipoPrestamo.CurrentRow.DataBoundItem;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCodigo.Text = tp.Codigo;
            txtDescripcion.Text = tp.Descripcion;
            txtInteres.Text = Convert.ToString(tp.InteresBase);

        }

        private void dgvTipoPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
