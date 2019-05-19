﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void tsmTipoPrestamo_Click(object sender, EventArgs e)
        {
            frmTipoPrestamo form = new frmTipoPrestamo();
            form.Show();
        }
        private void tsmPrestamo_Click(object sender, EventArgs e)
        {
            frmPrestamo form = new frmPrestamo();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluacionCredito form = new frmEvaluacionCredito();
            form.Show();
        }

        private void registroDeMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoneda form = new frmMoneda();
            form.Show();
        }
    }
}
