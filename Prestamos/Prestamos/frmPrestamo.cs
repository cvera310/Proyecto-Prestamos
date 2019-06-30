using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    
    public partial class frmPrestamo : MetroFramework.Forms.MetroForm
    {
        CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
        Prestamo prestamo;
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = LoginUsuario.UsuarioConectado();
            CargarcmbCantCuota();
            dgvPrestamoDetalle.AutoGenerateColumns = true;
            cmbMoneda.DataSource = Moneda.ListarMoneda();
            cmbTipoPrestamo.DataSource = TipoPrestamo.ObtenerTipoPrestamos();
            LimpiarFormulario();
            BloquearFormulario();
            prestamo = new Prestamo();
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
            prestamo.Fecha = dtpFecha.Value.Date;
            prestamo.tipoPrestamo = (TipoPrestamo)cmbTipoPrestamo.SelectedItem;
            prestamo.MontoSolicitado = Convert.ToInt32(txtMontoSolicitado.Text.Replace(".", ""));
            prestamo.moneda = (Moneda)cmbMoneda.SelectedItem;
            prestamo.InteresBase = Convert.ToInt32(txtInteres.Text);
            prestamo.CantidadCuota = Convert.ToInt32(cmbCantCuota.SelectedItem);
            prestamo.Saldo = Convert.ToDouble(txtSaldo.Text.Replace(".", ""));
            prestamo.MontoTotal = Convert.ToDouble(txtMontoTotal.Text.Replace(".", ""));
            prestamo.cliente = txtCiCliente.Text;

            return prestamo;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = ObtenerFormulario();
            Prestamo.Agregar(prestamo);
            
            LimpiarFormulario();
            BloquearFormulario();
            prestamo = new Prestamo();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Confirma la generación de las cuotas?", "Generacion de cuotas", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (cmbTipoPrestamo.SelectedItem != null && cmbMoneda.SelectedItem != null && cmbCantCuota.SelectedItem != null)
                {
                    Prestamo.ListaPrestamo.Clear();
                    double Total = 0;
                    int MontoSolicitado = Convert.ToInt32(txtMontoSolicitado.Text.Replace(".", ""));
                    double Interes = Convert.ToDouble(txtInteres.Text);
                    double InteresGenerado = 0;
                    int CantCuota = Convert.ToInt32(cmbCantCuota.SelectedItem);
                    Double MontoCuota;
                    InteresGenerado = MontoSolicitado * (Interes / 100);
                    Total = MontoSolicitado + (MontoSolicitado * (Interes / 100));

                    MontoCuota = Math.Round((Total / CantCuota), 0);

                    txtInteresGenerado.Text = String.Format(elGR, "{0:0,0}", InteresGenerado);
                    Total = MontoCuota * CantCuota;
                    txtMontoTotal.Text = String.Format(elGR, "{0:0,0}", Total);//FORMATEA EL MONTO TOTAL CON SEPARADOR DE MILES
                    txtSaldo.Text = txtMontoTotal.Text;

                    for (int i = 1; i <= CantCuota; i++)
                    {
                        PrestamoDetalle prestamoDetalle = new PrestamoDetalle();
                        prestamoDetalle.NroCuota = i;
                        prestamoDetalle.MontoDetalle = MontoCuota;
                        prestamoDetalle.SaldoDetalle = MontoCuota;
                        prestamoDetalle.estado = EstadoPrestamo.No_pagado;
                        prestamoDetalle.Vencimiento = dtpFecha.Value.Date.AddMonths(i);
                        prestamo.ListaPrestamoDetalle.Add(prestamoDetalle);
                        PrestamoDetalle.Agregar(prestamoDetalle);
                       
                    }

                    ActualizarDgv();
                    btnModificar.Enabled = true;
                    btnConfirmar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            txtCiCliente.Text = null;
            txtNombreCliente.Text = null;
            txtInteresGenerado.Text = null;
            cmbMoneda.SelectedItem = null;
            dgvPrestamoDetalle.DataSource = null;
        }

        private void dgvPrestamoDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            PrestamoDetalle prestamoDetalle = (PrestamoDetalle)dgvPrestamoDetalle.CurrentRow.DataBoundItem;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Los datos introducidos se perderán, continuar?", "Cancelar", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                LimpiarFormulario();
            }
        }

        private void cmbTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQLTipoPrestamo = "SELECT tpre_interes FROM tipo_prestamo WHERE tpre_descripcion='" + cmbTipoPrestamo.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(SQLTipoPrestamo, con);
                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();
                
                while (elLectorDeDatos.Read())
                {
                    txtInteres.Text = Convert.ToString(elLectorDeDatos.GetInt32(0));
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMontoSolicitado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCiCliente_Leave(object sender, EventArgs e)
        {
            if (txtCiCliente.Text.Trim() != "")
            {
                Cliente cliente = Cliente.ListarClienteId(txtCiCliente.Text);

                if (cliente != null)
                {
                    txtNombreCliente.Text = cliente.Nombre + ", " + cliente.Apellido;
                    DesbloquearFormulario();
                }
                else
                {
                    txtNombreCliente.Text = "Inexistente";
                    txtCiCliente.Focus();
                }
            }
        }

        private void txtCiCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BloquearFormulario()
        {
            cmbTipoPrestamo.Enabled = false;
            txtMontoSolicitado.Enabled = false;
            cmbMoneda.Enabled = false;
            cmbCantCuota.Enabled = false;
            btnGenerar.Enabled = false;
            btnModificar.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void DesbloquearFormulario()
        {
            cmbTipoPrestamo.Enabled = true;
            txtMontoSolicitado.Enabled = true;
            cmbMoneda.Enabled = true;
            cmbCantCuota.Enabled = true;
            btnGenerar.Enabled = true;
            
        }

        private void txtMontoSolicitado_Leave(object sender, EventArgs e)
        {
            int monto = Convert.ToInt32(txtMontoSolicitado.Text);
            txtMontoSolicitado.Text = String.Format(elGR, "{0:0,0}", monto);
        }
    }
}
