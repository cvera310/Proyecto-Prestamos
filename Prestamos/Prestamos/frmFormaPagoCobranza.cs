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
    public partial class frmFormaPagoCobranza : MetroFramework.Forms.MetroForm
    {
       
        private int? totalEfectivo = 0;
        public frmFormaPagoCobranza(int total) : this()
        {
            this.totalEfectivo = total;
        }

        public frmFormaPagoCobranza()
        {
            InitializeComponent();
        }

        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                txtEfectivo.Text = String.Format(elGR, "{0:0,0}", totalEfectivo);
                               
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            int i = 0;

            //cobranza.detalle_fpagocobranza.Clear();
            if (txtEfectivo.Text.Replace(".", "") == null) txtEfectivo.Text = "0";
            foreach (DataGridViewRow row in dgvCheques.Rows)
            {
                //Cobranza.detalle_fpagocobranza.Clear();
                //DetalleFpagoCobranza.ListaDetallefpagoCobranza.Clear();
                if (row.Cells[i].Value != null)
                {
                    DetalleFpagoCobranza d = new DetalleFpagoCobranza();
                    d.cheque = FormaPago.ObtenerFormaPago(row.Cells["TipoCheque"].Value.ToString());
                    d.numeroCheque = Convert.ToInt32(row.Cells["numeroCheque"].Value);
                    d.fechaCheque = Convert.ToDateTime(row.Cells["fechaCheque"].Value);
                    d.montoCheque = Convert.ToInt32(row.Cells["montoCheque"].Value);
                    
                    Cobranza.detalle_fpagocobranza.Add(d);
                    DetalleFpagoCobranza.Agregar(d);
                    
                    i++;
                }
                    
            }
                //AGREGAMOS EFECTIVO COMO UN CHEQUE MAS
                DetalleFpagoCobranza d2 = new DetalleFpagoCobranza();
                d2.cheque = FormaPago.ObtenerFormaPago("EFE");
                d2.numeroCheque = 0;
                d2.fechaCheque = Convert.ToDateTime(System.DateTime.Now.Date.ToShortDateString());
                d2.montoCheque = Convert.ToInt32(txtEfectivo.Text.Replace(".", ""));
                Cobranza.detalle_fpagocobranza.Add(d2);
                DetalleFpagoCobranza.Agregar(d2);

            
            this.Close();
        }

        private void frmFormaPagoCobranza_Load(object sender, EventArgs e)
        {
            txtEfectivo.Focus();
            txtEfectivo.Text = "0";
            dgvCheques.AutoGenerateColumns = false;
            
            DataGridViewComboBoxColumn cmbTipoCheque = dgvCheques.Columns["TipoCheque"] as DataGridViewComboBoxColumn;
            cmbTipoCheque.DataSource = FormaPago.ObtenerCheques();
            cmbTipoCheque.DisplayMember = "descripcion";
            cmbTipoCheque.ValueMember = "codigo";
            
           // dgvCheques.DataSource = DetalleFpagoCobranza.ObtenerDetalles();
            //MessageBox.Show("FALTA AGREGAR VERIFICACIONES DE CAMPOS VACIOS Y DEMAS PARA EL DATAGRID Y CARGAR VALORES CONTENIDOS EN LA CLASE");
        }

        private void dgvCheques_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCheques.CurrentCell.ColumnIndex == 1 || dgvCheques.CurrentCell.ColumnIndex == 3)
            {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;


            }
        }

        private Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dgvCheques_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Validamos si no es una fila nueva
            if (!dgvCheques.Rows[e.RowIndex].IsNewRow)
            {
                //Sólo controlamos el dato de la columna 0
                if (e.ColumnIndex == 2)
                {
                    if (!this.EsFecha(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("El dato introducido no es de tipo fecha", "Error de validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvCheques.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo fecha";
                        e.Cancel = true;
                    }
                    else if (Convert.ToDateTime(e.FormattedValue.ToString()) <= Convert.ToDateTime(System.DateTime.Now.ToShortDateString()))
                    {
                        MessageBox.Show("La fecha debe ser superior al dia actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void dgvCheques_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvCheques.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void dgvCheques_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCheques.CurrentCell.ColumnIndex == 1 || dgvCheques.CurrentCell.ColumnIndex == 3)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvCheques_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvCheques_KeyPress);
                }

            }
        }

        private void dgvCheques_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[2].Value = DateTime.Now.Date.ToShortDateString();
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvCheques_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (dgvCheques.CurrentCell.ColumnIndex == 3)
            {
                if (e.KeyCode == Keys.F3)
                {
                    dgvCheques.Rows[dgvCheques.cell].SetValues = totalEfectivo.ToString();
                }
            }*/
        }
    }
}
