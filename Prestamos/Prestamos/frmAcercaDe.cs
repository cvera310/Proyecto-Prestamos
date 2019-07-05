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
    public partial class frmAcercaDe : MetroFramework.Forms.MetroForm
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desastre ko Marito",
                        "Ñembo Easter Egg");
        }
    }
}
