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
    public partial class frmEvaluacionCredito : MetroFramework.Forms.MetroForm
    {
        public frmEvaluacionCredito()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEvaluacionCredito_Load(object sender, EventArgs e)
        {
            // cmbCliente.DataSource = BibliotecaClases.Cliente.ListarCliente();
            cmbTipoEgreso.DataSource = Enum.GetValues(typeof(DetalleEgresos.TipoEgreso));
            cmbTipoIngreso.DataSource = Enum.GetValues(typeof(DetalleIngresos.TipoIngreso));
            cmbTipoIngreso.SelectedItem = null;
            cmbTipoEgreso.SelectedItem = null;
            txtCliente.Focus();
            BloquearFormulario();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EvaluacionCredito evaluacion = ObtenerEvaluacionFormulario();

            EvaluacionCredito.Agregar(evaluacion);

            

            LimpiarFormulario();

            MessageBox.Show("La solcitud se ingreso correctamente");





        }

        private void btnTotalEngreso_Click(object sender, EventArgs e)
        {
            double totalEgreso = 0;

            EvaluacionCredito ec = new EvaluacionCredito();

            foreach (DataGridViewRow row in dgvEgreso.Rows)
            {
                totalEgreso += Convert.ToDouble(row.Cells["monto_egreso"].Value);  

            }

            txtTotalEgresos.Text = Convert.ToString(ec.TotalEgresos);

            txtTotalEgresos.Text = Convert.ToString(totalEgreso);
        }

        private void btnTotalIngreso_Click(object sender, EventArgs e)
        {
            double totalIngreso = 0;
            EvaluacionCredito ec = new EvaluacionCredito();
            
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                totalIngreso += Convert.ToDouble(row.Cells["monto_ingreso"].Value);
            }

            txtTotalIngresos.Text = Convert.ToString(ec.TotalIngresos);
            txtTotalIngresos.Text = Convert.ToString(totalIngreso);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Cliente cliente = (Cliente)cmbCliente.SelectedItem;
           // txtRazonSocial.Text = cliente.RazonSocial;
           // txtDireccion.Text = cliente.Direccion;
            //txtTelefono.Text = cliente.Telefono;
            //cmbTipoDoc.SelectedItem = cliente.TipoDeDocumento;
            //cmbSexo.SelectedItem = cliente.sexo;
            //dtpFechaNac.Value = cliente.Nacimiento;

        }

        private EvaluacionCredito ObtenerEvaluacionFormulario()
        {
            EvaluacionCredito evaluacion = new EvaluacionCredito();
            // evaluacion.cliente = (Cliente)cmbCliente.SelectedItem;
            //evaluacion.Alimentacion = Convert.ToInt16(txtAlimentacion.Text);
            //evaluacion.Alquiler = Convert.ToInt16(txtAlquiler.Text);
            //evaluacion.ServiciosBasicos = Convert.ToInt16(txtServicios.Text);
            //evaluacion.Transporte = Convert.ToInt16(txtTransporte.Text);
            //evaluacion.Salario = Convert.ToInt16(txtSalario.Text);
            //evaluacion.Otros = Convert.ToInt16(txtOtros.Text);
            //evaluacion.IngresoExtra = Convert.ToInt16(txtIngresoExtra.Text);
            //evaluacion.tipo_pago = (EvaluacionCredito.TipoPago)cmbTipoPago.SelectedItem;
            evaluacion.cliente = txtCliente.Text;
            evaluacion.informconf = txtInformconf.Text;
            evaluacion.TotalEgresos = Convert.ToDouble(txtTotalEgresos.Text);
            evaluacion.TotalIngresos = Convert.ToDouble(txtTotalIngresos.Text);


            return evaluacion;
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloquearFormulario()
        {
            txtDireccion.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtTelefono.Enabled = false;
           
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != "")
            {
                Cliente cliente = Cliente.ListarClienteId(txtCliente.Text);

                if (cliente != null)
                {
                    txtNombreCliente.Text = cliente.Nombre + ", " + cliente.Apellido;
                    txtTelefono.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                    txtRazonSocial.Text = cliente.RazonSocial;
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente");
                    txtCliente.Focus();
                }
            }
        }

        private void btnInformconf_Click(object sender, EventArgs e)
        {
            string resultado = EvaluacionCredito.ConsultaInformconf(txtCliente.Text);
            txtInformconf.Text = resultado;

            if (resultado == "S")
            {
                MessageBox.Show("Cliente con Informconf", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Cliente sin Informconf");
                
            }



        }

        private void btnAgregarEgreso_Click(object sender, EventArgs e)
        {
            DetalleEgresos de = new DetalleEgresos();
            de.monto_egreso = Convert.ToDouble(txtMontoEgreso.Text);
            de.tipo_egreso = (DetalleEgresos.TipoEgreso)cmbTipoEgreso.SelectedItem;
            EvaluacionCredito.detalle_egresos.Add(de);

            ActualizarDataGridEgresos();

        }

        private void ActualizarDataGridEgresos()
        {
            dgvEgreso.DataSource = null;
            dgvEgreso.DataSource = EvaluacionCredito.detalle_egresos;
        }

        private void ActualizarDataGridIngresos()
        {
            dgvIngreso.DataSource = null;
            dgvIngreso.DataSource = EvaluacionCredito.detalle_ingresos;
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            DetalleIngresos di = new DetalleIngresos();
            di.monto_ingreso = Convert.ToDouble(txtMontoIngreso.Text);
            di.tipo_ingreso = (DetalleIngresos.TipoIngreso)cmbTipoIngreso.SelectedItem;
            EvaluacionCredito.detalle_ingresos.Add(di);

            ActualizarDataGridIngresos();
        }

        private void btnEliminarEgreso_Click(object sender, EventArgs e)
        {
            DetalleEgresos de = (DetalleEgresos)dgvIngreso.CurrentRow.DataBoundItem;
            if (de !=null)
            {
                EvaluacionCredito.detalle_egresos.Remove(de);
            }

            ActualizarDataGridEgresos();


        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            DetalleIngresos di = (DetalleIngresos)dgvIngreso.CurrentRow.DataBoundItem;
            if (di !=null) {
                EvaluacionCredito.detalle_ingresos.Remove(di);
            }

            ActualizarDataGridIngresos();
        }


        private void LimpiarFormulario()
        {
            cmbTipoEgreso.SelectedItem = null;
            cmbTipoIngreso.SelectedItem = null;
            txtCliente.Text = "";
            txtDireccion.Text = "";
            txtInformconf.Text = "";
            txtNombreCliente.Text = "";
            txtNombreCliente.Text = "";
            txtTotalEgresos.Text = "";
            txtTotalIngresos.Text = "";
            dgvEgreso.DataSource = null;
            dgvIngreso.DataSource = null;
            txtMontoEgreso.Text = "";
            txtMontoIngreso.Text = "";
        }

    }
}
