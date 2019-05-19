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
    public partial class frmEvaluacionCredito : Form
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

        }
    }
}
