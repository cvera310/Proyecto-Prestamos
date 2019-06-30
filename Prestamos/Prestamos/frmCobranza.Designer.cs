namespace Prestamos
{
    partial class frmCobranza
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
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCobro = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbCobranza = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTotalImputado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFormaPago = new System.Windows.Forms.Button();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDcto = new System.Windows.Forms.TextBox();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalGral = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbCliente.SuspendLayout();
            this.grbCobro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.grbCobranza.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtDireccion);
            this.grbCliente.Controls.Add(this.label4);
            this.grbCliente.Controls.Add(this.txtTelefonoCliente);
            this.grbCliente.Controls.Add(this.label3);
            this.grbCliente.Controls.Add(this.txtNombreCliente);
            this.grbCliente.Controls.Add(this.label2);
            this.grbCliente.Controls.Add(this.txtCiCliente);
            this.grbCliente.Controls.Add(this.label1);
            this.grbCliente.Location = new System.Drawing.Point(16, 60);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(767, 105);
            this.grbCliente.TabIndex = 5;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(80, 58);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(215, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dirección:";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Enabled = false;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(572, 19);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(82, 20);
            this.txtTelefonoCliente.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefono:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(297, 18);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(209, 20);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // txtCiCliente
            // 
            this.txtCiCliente.Location = new System.Drawing.Point(84, 19);
            this.txtCiCliente.MaxLength = 10;
            this.txtCiCliente.Name = "txtCiCliente";
            this.txtCiCliente.Size = new System.Drawing.Size(78, 20);
            this.txtCiCliente.TabIndex = 6;
            this.txtCiCliente.Leave += new System.EventHandler(this.txtCiCliente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "C.I. Cliente:";
            // 
            // grbCobro
            // 
            this.grbCobro.Controls.Add(this.btnCalcular);
            this.grbCobro.Controls.Add(this.dgvPendientes);
            this.grbCobro.Location = new System.Drawing.Point(16, 322);
            this.grbCobro.Name = "grbCobro";
            this.grbCobro.Size = new System.Drawing.Size(767, 313);
            this.grbCobro.TabIndex = 6;
            this.grbCobro.TabStop = false;
            this.grbCobro.Text = "Documentos pendientes de cobro";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::Prestamos.Properties.Resources.calc;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(652, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 34);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular Montos";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvPendientes.Location = new System.Drawing.Point(8, 20);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.Size = new System.Drawing.Size(753, 247);
            this.dgvPendientes.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Width = 88;
            // 
            // grbCobranza
            // 
            this.grbCobranza.Controls.Add(this.lblFecha);
            this.grbCobranza.Controls.Add(this.txtTotalImputado);
            this.grbCobranza.Controls.Add(this.label10);
            this.grbCobranza.Controls.Add(this.btnFormaPago);
            this.grbCobranza.Controls.Add(this.txtRecibo);
            this.grbCobranza.Controls.Add(this.label6);
            this.grbCobranza.Controls.Add(this.label5);
            this.grbCobranza.Location = new System.Drawing.Point(16, 187);
            this.grbCobranza.Name = "grbCobranza";
            this.grbCobranza.Size = new System.Drawing.Size(767, 100);
            this.grbCobranza.TabIndex = 7;
            this.grbCobranza.TabStop = false;
            this.grbCobranza.Text = "Cobranza";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(260, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 13);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "fecha";
            // 
            // txtTotalImputado
            // 
            this.txtTotalImputado.Enabled = false;
            this.txtTotalImputado.Location = new System.Drawing.Point(572, 33);
            this.txtTotalImputado.MaxLength = 10;
            this.txtTotalImputado.Name = "txtTotalImputado";
            this.txtTotalImputado.ReadOnly = true;
            this.txtTotalImputado.Size = new System.Drawing.Size(108, 20);
            this.txtTotalImputado.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total imputado:";
            // 
            // btnFormaPago
            // 
            this.btnFormaPago.Image = global::Prestamos.Properties.Resources.money;
            this.btnFormaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormaPago.Location = new System.Drawing.Point(371, 31);
            this.btnFormaPago.Name = "btnFormaPago";
            this.btnFormaPago.Size = new System.Drawing.Size(101, 23);
            this.btnFormaPago.TabIndex = 21;
            this.btnFormaPago.Text = "Forma de pago";
            this.btnFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormaPago.UseVisualStyleBackColor = true;
            this.btnFormaPago.Click += new System.EventHandler(this.btnFormaPago_Click);
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(80, 33);
            this.txtRecibo.MaxLength = 10;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.Size = new System.Drawing.Size(108, 20);
            this.txtRecibo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nro. Recibo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total dcto:";
            // 
            // txtDcto
            // 
            this.txtDcto.Location = new System.Drawing.Point(334, 653);
            this.txtDcto.Name = "txtDcto";
            this.txtDcto.ReadOnly = true;
            this.txtDcto.Size = new System.Drawing.Size(82, 20);
            this.txtDcto.TabIndex = 9;
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(511, 653);
            this.txtMora.Name = "txtMora";
            this.txtMora.ReadOnly = true;
            this.txtMora.Size = new System.Drawing.Size(82, 20);
            this.txtMora.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 655);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total mora:";
            // 
            // txtTotalGral
            // 
            this.txtTotalGral.Location = new System.Drawing.Point(694, 652);
            this.txtTotalGral.Name = "txtTotalGral";
            this.txtTotalGral.ReadOnly = true;
            this.txtTotalGral.Size = new System.Drawing.Size(82, 20);
            this.txtTotalGral.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(602, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total  a pagar:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Prestamos.Properties.Resources.save;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(694, 715);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Prestamos.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(595, 715);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCobranza
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(799, 771);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtTotalGral);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDcto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbCobranza);
            this.Controls.Add(this.grbCobro);
            this.Controls.Add(this.grbCliente);
            this.Name = "frmCobranza";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Cobranza";
            this.Load += new System.EventHandler(this.frmCobranza_Load);
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbCobro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.grbCobranza.ResumeLayout(false);
            this.grbCobranza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbCobro;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.GroupBox grbCobranza;
        private System.Windows.Forms.Button btnFormaPago;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDcto;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalGral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalImputado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnCalcular;
    }
}