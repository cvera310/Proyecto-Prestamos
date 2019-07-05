using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace Prestamos
{
    public partial class frmAprobarSolicitud : MetroFramework.Forms.MetroForm
    {
        public frmAprobarSolicitud()
        {
            InitializeComponent();
        }

        private void frmAprobarSolicitud_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }


        private void ActualizarDataGrid()
        {
            dgvPendientes.DataSource = null;
            dgvPendientes.DataSource = EvaluacionCredito.ObtenerPendientes();
            dgvPendientes.Columns[1].Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Confirma la solicitud?", "Confirmar Solicitud", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {


                 List<int> listaPend = new List<int>();
                    foreach (DataGridViewRow registro in dgvPendientes.Rows)
                 {
                    if (registro.Cells[0].Value == null) registro.Cells[0].Value = false;
                    if ((bool)registro.Cells[0].Value == true)
                    {
                    listaPend.Add((int)registro.Cells[1].Value);

                     }

                }
            EvaluacionCredito.ConfirmarPendientes(listaPend);
            ActualizarDataGrid();
             }
        }
    }
}
