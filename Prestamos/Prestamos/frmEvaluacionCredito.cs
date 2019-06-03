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
            cmbTipoDoc.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbTipoPago.DataSource = Enum.GetValues(typeof(EvaluacionCredito.TipoPago));
            cmbCliente.DataSource = BibliotecaClases.Cliente.ListarCliente();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EvaluacionCredito evaluacion = ObtenerEvaluacionFormulario();

            EvaluacionCredito.Agregar(evaluacion);


            

        }

        private void btnTotalEngreso_Click(object sender, EventArgs e)
        {
            EvaluacionCredito ec = new EvaluacionCredito();
            ec.Alimentacion = Convert.ToInt16(txtAlimentacion.Text);
            ec.Alquiler = Convert.ToInt16(txtAlquiler.Text);
            ec.Transporte = Convert.ToInt16(txtTransporte.Text);
            ec.ServiciosBasicos = Convert.ToInt16(txtServicios.Text);
            ec.Otros = Convert.ToInt16(txtOtros.Text);
            ec.TotalEgresos = (Convert.ToInt16(txtAlimentacion.Text)) + (Convert.ToInt16(txtAlquiler.Text)) + (Convert.ToInt16(txtTransporte.Text)) 
                + (Convert.ToInt16(txtServicios.Text)) + (Convert.ToInt16(txtOtros.Text));
            txtTotalEgresos.Text = Convert.ToString(ec.TotalEgresos);


        }

        private void btnTotalIngreso_Click(object sender, EventArgs e)
        {
            EvaluacionCredito ec = new EvaluacionCredito();
            ec.Salario = Convert.ToInt16(txtSalario.Text);
            ec.tipo_pago = (EvaluacionCredito.TipoPago)cmbTipoPago.SelectedItem;
            ec.IngresoExtra = Convert.ToInt16(txtIngresoExtra.Text);
            ec.TotalIngresos = (Convert.ToInt16(txtSalario.Text)) + (Convert.ToInt16(txtIngresoExtra.Text));
            txtTotalIngresos.Text = Convert.ToString(ec.TotalIngresos);

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            txtRazonSocial.Text = cliente.RazonSocial;
            txtDireccion.Text = cliente.Direccion;
            txtTelefono.Text = cliente.Telefono;
            cmbTipoDoc.SelectedItem = cliente.tipo_documento;
            cmbSexo.SelectedItem = cliente.sexo;
            dtpFechaNac.Value = cliente.Nacimiento;

        }

        private EvaluacionCredito ObtenerEvaluacionFormulario()
        {
            EvaluacionCredito evaluacion = new EvaluacionCredito();
            evaluacion.cliente = (Cliente)cmbCliente.SelectedItem;
            evaluacion.Alimentacion = Convert.ToInt16(txtAlimentacion.Text);
            evaluacion.Alquiler = Convert.ToInt16(txtAlquiler.Text);
            evaluacion.ServiciosBasicos = Convert.ToInt16(txtServicios.Text);
            evaluacion.Transporte = Convert.ToInt16(txtTransporte.Text);
            evaluacion.Salario = Convert.ToInt16(txtSalario.Text);
            evaluacion.Otros = Convert.ToInt16(txtOtros.Text);
            evaluacion.IngresoExtra = Convert.ToInt16(txtIngresoExtra.Text);
            evaluacion.tipo_pago = (EvaluacionCredito.TipoPago)cmbTipoPago.SelectedItem;
            evaluacion.TotalEgresos = Convert.ToInt16(txtTotalEgresos.Text);
            evaluacion.TotalIngresos = Convert.ToInt16(txtTotalIngresos.Text);


            return evaluacion;
        }




    }
}
