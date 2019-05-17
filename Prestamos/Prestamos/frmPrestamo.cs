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
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            CargarcmbCantCuota();
            LimpiarFormulario();
            dgvPrestamoDetalle.AutoGenerateColumns = true;
            cmbMoneda.DataSource = Moneda.ListarMoneda();
            cmbTipoPrestamo.DataSource = TipoPrestamo.ObtenerTipoPrestamo();
            cmbCliente.DataSource = BibliotecaClases.Cliente.ListarCliente();
        }

        public void CargarcmbCantCuota()
        {

            for (int i = 2; i <= 120; i++)
            {
                cmbCantCuota.Items.Add(i);
            }

        }

        public Prestamo ObtenerFormulario()
        {
            Prestamo prestamo = new Prestamo();
            prestamo.NumeroPrestamo = Convert.ToInt32(txtNumero.Text);
            prestamo.Fecha = dtpFecha.Value.Date;
            prestamo.cliente = (BibliotecaClases.Cliente)cmbCliente.SelectedItem;
            prestamo.tipoPrestamo = (TipoPrestamo)cmbTipoPrestamo.SelectedItem;
            prestamo.MontoSolicitado = Convert.ToInt32(txtMontoSolicitado.Text);
            prestamo.moneda = (Moneda)cmbMoneda.SelectedItem;
            prestamo.InteresBase = Convert.ToDouble(txtInteres.Text);
            prestamo.CantidadCuota = Convert.ToInt32(cmbCantCuota.SelectedItem);
            prestamo.Saldo = Convert.ToDouble(txtSaldo.Text);
            prestamo.MontoTotal = Convert.ToDouble(txtMontoTotal.Text);

            return prestamo;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = ObtenerFormulario();
            Prestamo.Agregar(prestamo);
            LimpiarFormulario();

            prestamo = new Prestamo();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            double Total = 0;
            int MontoSolicitado = Convert.ToInt32(txtMontoSolicitado.Text);
            double Interes = Convert.ToDouble(txtInteres.Text);
            double InteresGenerado = 0;
            int CantCuota = Convert.ToInt32(cmbCantCuota.SelectedItem);
            Double MontoCuota;
            InteresGenerado = MontoSolicitado * (Interes / 100);
            Total = MontoSolicitado + (MontoSolicitado * (Interes / 100));

            MontoCuota = Math.Round((Total / CantCuota), 0);

            txtMontoTotal.Text = (MontoCuota * CantCuota).ToString("N", nfi);

            for (int i = 1; i <= CantCuota; i++)
            {
                PrestamoDetalle prestamoDetalle = new PrestamoDetalle();
                prestamoDetalle.NroCuota = i;
                prestamoDetalle.NumeroPrestamo = Convert.ToInt32(txtNumero.Text);
                prestamoDetalle.MontoDetalle = MontoCuota;
                prestamoDetalle.SaldoDetalle = MontoCuota;
                prestamoDetalle.estado = EstadoPrestamo.No_pagado;
                prestamoDetalle.Vencimiento = dtpFecha.Value.Date.AddMonths(i);
                PrestamoDetalle.Agregar(prestamoDetalle);

            }

            ActualizarDgv();

        }

        private void ActualizarDgv()
        {
            dgvPrestamoDetalle.DataSource = null;
            dgvPrestamoDetalle.DataSource = PrestamoDetalle.ObtenerPrestamoDetalle();

        }
        private void LimpiarFormulario()
        {
            txtNumero.Text = null;
            txtMontoSolicitado.Text = "0";
            txtInteres.Text = null;
            txtSaldo.Text = "0";
            txtMontoTotal.Text = "0";
            dgvPrestamoDetalle.DataSource = null;
            dtpFecha.Value = System.DateTime.Now;
            cmbTipoPrestamo.SelectedItem = null;
            cmbCantCuota.SelectedItem = null;
            cmbCliente.SelectedItem = null;
            cmbMoneda.SelectedItem = null;
            dgvPrestamoDetalle.DataSource = null;
        }

        private void dgvPrestamoDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            PrestamoDetalle prestamoDetalle = (PrestamoDetalle)dgvPrestamoDetalle.CurrentRow.DataBoundItem;
            txtNumero.Text = Convert.ToString(prestamoDetalle.NumeroPrestamo);
            //dtpFecha.Value = prestamoDetalle.Fecha;
            cmbCliente.SelectedItem = prestamoDetalle.cliente;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


    }
}
