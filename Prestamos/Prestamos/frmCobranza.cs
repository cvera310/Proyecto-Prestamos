using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class frmCobranza : MetroFramework.Forms.MetroForm
    {
        Cobranza cobranza;
        CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
        public frmCobranza()
        {
            InitializeComponent();
        }
       
        private void txtCiCliente_Leave(object sender, EventArgs e)
        {
            if (txtCiCliente.Text.Trim() != "")
            {
                Cliente cliente = Cliente.ListarClienteId(txtCiCliente.Text);

                if (cliente != null)
                {
                    txtNombreCliente.Text = cliente.Nombre + ", " + cliente.Apellido;
                    txtTelefonoCliente.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                    CargarDgvCuotas();
                    DesbloquearFormulario();
                    txtRecibo.Text = Cobranza.ObtenerNroRecibo().ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente");
                    txtCiCliente.Focus();
                }
            }
        }

        private void BloquearFormulario()
        {
            btnCalcular.Enabled = false;
            btnFormaPago.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void DesbloquearFormulario()
        {
            btnCalcular.Enabled = true;
            btnFormaPago.Enabled = true;
           
        }
        private void CargarDgvCuotas()
        {
            dgvPendientes.DataSource = null;
            dgvPendientes.DataSource = Cobranza.ObtenerPrestamoCliente(txtCiCliente.Text);
            dgvPendientes.Columns[7].Visible = false;
            dgvPendientes.Columns[8].Visible = false;
        }
        
        private void CalcularTotales()
        {
            int totalMora = 0;
            int totalDcto = 0;
            int totalGral = 0;
            //cobranza.detalle_cobranza.Clear();
            foreach (DataGridViewRow registro in dgvPendientes.Rows)
            {
                if (registro.Cells[0].Value == null) registro.Cells[0].Value = false;
                if ((bool)registro.Cells[0].Value == true)
                {
                    CobranzaDetalle cobranzaDetalle = new CobranzaDetalle();
                    totalMora = totalMora + Convert.ToInt32(registro.Cells[6].Value);
                    totalDcto = totalDcto + Convert.ToInt32(registro.Cells[7].Value)*-1;
                    totalGral = totalGral + (Convert.ToInt32(registro.Cells[4].Value)+ Convert.ToInt32(registro.Cells[7].Value) * -1 + Convert.ToInt32(registro.Cells[6].Value));

                    cobranzaDetalle.cobranzaId = Convert.ToInt32(txtRecibo.Text);
                    cobranzaDetalle.prestamoId = Convert.ToInt32(registro.Cells[8].Value);
                    cobranzaDetalle.mora = Convert.ToInt32(registro.Cells[6].Value);
                    cobranzaDetalle.dcto = Convert.ToInt32(registro.Cells[7].Value);
                    cobranza.detalle_cobranza.Add(cobranzaDetalle);

                }

            }
           
            txtDcto.Text = String.Format(elGR, "{0:0,0}", totalDcto);
            txtMora.Text = String.Format(elGR, "{0:0,0}", totalMora);
            txtTotalGral.Text = String.Format(elGR, "{0:0,0}", totalGral);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private int? totalImputado = 0;
        public frmCobranza(int total) : this()
        {
            this.totalImputado = total;
        }

        private void btnFormaPago_Click(object sender, EventArgs e)
        {

            CalcularTotales();
            if (Convert.ToInt32(txtTotalGral.Text.Trim().Replace(".", "")) != 0)
            {
                frmFormaPagoCobranza testDialog = new frmFormaPagoCobranza(Convert.ToInt32(txtTotalGral.Text.Replace(".", "")));

                if (testDialog.ShowDialog(this) != DialogResult.OK)
                {
                    int monto = Convert.ToInt32(DetalleFpagoCobranza.ObtenerTotal());
                    txtTotalImputado.Text = String.Format(elGR, "{0:0,0}", monto);
                    if (Convert.ToInt32(monto) > 0) btnConfirmar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar alguna fila para calcular el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCobranza_Load(object sender, EventArgs e)
        {
            lblFecha.Text = System.DateTime.Now.ToShortDateString().ToString();
            LimpiarFormulario();
            BloquearFormulario();
            cobranza = new Cobranza();
        }

        private void LimpiarFormulario()
        {
            txtTotalImputado.Text = "0";
            txtMora.Text = "0";
            txtDcto.Text = "0";
            txtTotalImputado.Text = "0";
            txtTotalGral.Text = "0";
            txtCiCliente.Text = null;
            txtNombreCliente.Text = null;
            txtTelefonoCliente.Text = null;
            txtDireccion.Text = null;
            dgvPendientes.DataSource = null;
            txtRecibo.Text = null;
            txtTotalImputado.Text = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTotalGral.Text.Replace(".", "")) != Convert.ToInt32(txtTotalImputado.Text.Replace(".", "")))
            {
                MessageBox.Show("El monto imputado es diferente al total.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                cobranza.MontoTotal = Convert.ToInt32(txtTotalGral.Text.Replace(".",""));
                cobranza.TotalDcto = Convert.ToInt32(txtDcto.Text.Replace(".", ""));
                cobranza.TotalMora = Convert.ToInt32(txtMora.Text.Replace(".", ""));
                int id = Cobranza.Agregar(cobranza);
                Recibo recibo = new Recibo();
                recibo.SetParameterValue("@Idcab", id);
                recibo.SetParameterValue("@Iddet", id);
                frmRecibo reci = new frmRecibo();
                reci.crvRecibo.ReportSource = recibo;
                MessageBox.Show("Cobranza registrada con exito, a continuación se emitirá el recibo");
                reci.ShowDialog();
                LimpiarFormulario();
                DetalleFpagoCobranza.ListaDetallefpagoCobranza.Clear();
                Cobranza.detalle_fpagocobranza.Clear();
                cobranza = new Cobranza();
                
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DetalleFpagoCobranza.ListaDetallefpagoCobranza.Clear();
            Cobranza.detalle_fpagocobranza.Clear();
            LimpiarFormulario();
        }
    }
}
