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
    public partial class frmMoneda : Form
    {
        Moneda moneda;

        public frmMoneda()
        {
            InitializeComponent();
        }

        private void frmMoneda_Load(object sender, EventArgs e)
        {



            moneda = new Moneda();
            dtgDetalleMoneda.AutoGenerateColumns = true;
            

            if (Moneda.ObtenerMoneda() != null)
            {
                ActualizarDataGrid();
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Moneda md = new Moneda();

            if (txtCodigo != null && txtDescripcion != null && txtPais != null)
            {
                
                //MonedaDetalle md = new MonedaDetalle();
                md.PaisProcedencia = txtPais.Text;
                md.Codigo = Convert.ToInt16(txtCodigo.Text);
                md.Descripcion = txtDescripcion.Text;

                Moneda.Agregar(md);
                //moneda.detalle_moneda.Add(md);

                ActualizarDataGrid();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }

           

        }

        private void ActualizarDataGrid()
        {
            dtgDetalleMoneda.DataSource = null;
            dtgDetalleMoneda.DataSource = Moneda.ObtenerMoneda();
        }

        private void Limpiar()
        {
            txtCodigo.Text = "0";
            txtDescripcion.Text = "";
            txtPais.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Moneda md = (Moneda)dtgDetalleMoneda.CurrentRow.DataBoundItem;
            if (md != null)
            {
                Moneda.ListaMoneda.Remove(md);
            }
            ActualizarDataGrid();

        }

        private void dtgDetalleMoneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
