namespace Prestamos
{
    partial class frmPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCantCuota = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.txtMontoSolicitado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrestamoDetalle = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(680, 126);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(680, 54);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(209, 101);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(89, 20);
            this.txtSaldo.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Saldo";
            // 
            // cmbCantCuota
            // 
            this.cmbCantCuota.FormattingEnabled = true;
            this.cmbCantCuota.Location = new System.Drawing.Point(96, 101);
            this.cmbCantCuota.Name = "cmbCantCuota";
            this.cmbCantCuota.Size = new System.Drawing.Size(49, 21);
            this.cmbCantCuota.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Location = new System.Drawing.Point(25, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Cant Cuotas";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(468, 20);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(148, 21);
            this.cmbCliente.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "%";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(588, 66);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(30, 20);
            this.txtInteres.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Moneda";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(469, 64);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(56, 21);
            this.cmbMoneda.TabIndex = 5;
            // 
            // txtMontoSolicitado
            // 
            this.txtMontoSolicitado.Location = new System.Drawing.Point(296, 65);
            this.txtMontoSolicitado.Name = "txtMontoSolicitado";
            this.txtMontoSolicitado.Size = new System.Drawing.Size(89, 20);
            this.txtMontoSolicitado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Monto solicitado";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(546, 128);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(87, 20);
            this.txtMontoTotal.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Monto Total";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(96, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(62, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nro prestamo";
            // 
            // dgvPrestamoDetalle
            // 
            this.dgvPrestamoDetalle.AllowUserToAddRows = false;
            this.dgvPrestamoDetalle.AllowUserToDeleteRows = false;
            this.dgvPrestamoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoDetalle.Location = new System.Drawing.Point(23, 181);
            this.dgvPrestamoDetalle.Name = "dgvPrestamoDetalle";
            this.dgvPrestamoDetalle.ReadOnly = true;
            this.dgvPrestamoDetalle.Size = new System.Drawing.Size(732, 283);
            this.dgvPrestamoDetalle.TabIndex = 40;
            this.dgvPrestamoDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamoDetalle_CellClick);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(650, 23);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 23);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar cuotas";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbTipoPrestamo
            // 
            this.cmbTipoPrestamo.FormattingEnabled = true;
            this.cmbTipoPrestamo.Location = new System.Drawing.Point(113, 65);
            this.cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            this.cmbTipoPrestamo.Size = new System.Drawing.Size(83, 21);
            this.cmbTipoPrestamo.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Tipo de prestamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "CUOTAS";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(238, 21);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(147, 20);
            this.dtpFecha.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(680, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 532);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTipoPrestamo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvPrestamoDetalle);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCantCuota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.txtMontoSolicitado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPrestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCantCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.TextBox txtMontoSolicitado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrestamoDetalle;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbTipoPrestamo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelar;
    }
}