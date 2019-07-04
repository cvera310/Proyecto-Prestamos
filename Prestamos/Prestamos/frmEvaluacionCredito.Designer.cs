namespace Prestamos
{
    partial class frmEvaluacionCredito
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtInformconf = new System.Windows.Forms.TextBox();
            this.btnInformconf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEgresos = new System.Windows.Forms.GroupBox();
            this.btnAgregarEgreso = new System.Windows.Forms.Button();
            this.btnEliminarEgreso = new System.Windows.Forms.Button();
            this.txtMontoEgreso = new System.Windows.Forms.TextBox();
            this.cmbTipoEgreso = new System.Windows.Forms.ComboBox();
            this.btnTotalEngreso = new System.Windows.Forms.Button();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbIngresos = new System.Windows.Forms.GroupBox();
            this.btnEliminarIngreso = new System.Windows.Forms.Button();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.txtMontoIngreso = new System.Windows.Forms.TextBox();
            this.cmbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.btnTotalIngreso = new System.Windows.Forms.Button();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvEgreso = new System.Windows.Forms.DataGridView();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.gbCliente.SuspendLayout();
            this.gbEgresos.SuspendLayout();
            this.gbIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtInformconf);
            this.gbCliente.Controls.Add(this.btnInformconf);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.txtRazonSocial);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Location = new System.Drawing.Point(22, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(750, 97);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Informacion del Cliente";
            // 
            // txtInformconf
            // 
            this.txtInformconf.Location = new System.Drawing.Point(638, 68);
            this.txtInformconf.Name = "txtInformconf";
            this.txtInformconf.ReadOnly = true;
            this.txtInformconf.Size = new System.Drawing.Size(83, 20);
            this.txtInformconf.TabIndex = 14;
            // 
            // btnInformconf
            // 
            this.btnInformconf.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformconf.Image = global::Prestamos.Properties.Resources.search;
            this.btnInformconf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformconf.Location = new System.Drawing.Point(476, 68);
            this.btnInformconf.Name = "btnInformconf";
            this.btnInformconf.Size = new System.Drawing.Size(131, 23);
            this.btnInformconf.TabIndex = 13;
            this.btnInformconf.Text = "Consultar Informconf";
            this.btnInformconf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformconf.UseVisualStyleBackColor = true;
            this.btnInformconf.Click += new System.EventHandler(this.btnInformconf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre y Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(292, 19);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(157, 20);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(52, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 10;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(536, 19);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(292, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(99, 55);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // gbEgresos
            // 
            this.gbEgresos.Controls.Add(this.btnAgregarEgreso);
            this.gbEgresos.Controls.Add(this.btnEliminarEgreso);
            this.gbEgresos.Controls.Add(this.txtMontoEgreso);
            this.gbEgresos.Controls.Add(this.cmbTipoEgreso);
            this.gbEgresos.Controls.Add(this.btnTotalEngreso);
            this.gbEgresos.Controls.Add(this.txtTotalEgresos);
            this.gbEgresos.Controls.Add(this.label9);
            this.gbEgresos.Controls.Add(this.label8);
            this.gbEgresos.Location = new System.Drawing.Point(22, 115);
            this.gbEgresos.Name = "gbEgresos";
            this.gbEgresos.Size = new System.Drawing.Size(750, 103);
            this.gbEgresos.TabIndex = 1;
            this.gbEgresos.TabStop = false;
            this.gbEgresos.Text = "Egresos";
            // 
            // btnAgregarEgreso
            // 
            this.btnAgregarEgreso.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEgreso.Image = global::Prestamos.Properties.Resources.add;
            this.btnAgregarEgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEgreso.Location = new System.Drawing.Point(13, 63);
            this.btnAgregarEgreso.Name = "btnAgregarEgreso";
            this.btnAgregarEgreso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEgreso.TabIndex = 15;
            this.btnAgregarEgreso.Text = "Agregar";
            this.btnAgregarEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEgreso.UseVisualStyleBackColor = true;
            this.btnAgregarEgreso.Click += new System.EventHandler(this.btnAgregarEgreso_Click);
            // 
            // btnEliminarEgreso
            // 
            this.btnEliminarEgreso.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEgreso.Image = global::Prestamos.Properties.Resources.delete;
            this.btnEliminarEgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEgreso.Location = new System.Drawing.Point(217, 63);
            this.btnEliminarEgreso.Name = "btnEliminarEgreso";
            this.btnEliminarEgreso.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEgreso.TabIndex = 6;
            this.btnEliminarEgreso.Text = "Eliminar";
            this.btnEliminarEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEgreso.UseVisualStyleBackColor = true;
            this.btnEliminarEgreso.Click += new System.EventHandler(this.btnEliminarEgreso_Click);
            // 
            // txtMontoEgreso
            // 
            this.txtMontoEgreso.Location = new System.Drawing.Point(372, 19);
            this.txtMontoEgreso.Name = "txtMontoEgreso";
            this.txtMontoEgreso.Size = new System.Drawing.Size(100, 20);
            this.txtMontoEgreso.TabIndex = 14;
            // 
            // cmbTipoEgreso
            // 
            this.cmbTipoEgreso.FormattingEnabled = true;
            this.cmbTipoEgreso.Location = new System.Drawing.Point(139, 18);
            this.cmbTipoEgreso.Name = "cmbTipoEgreso";
            this.cmbTipoEgreso.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEgreso.TabIndex = 13;
            // 
            // btnTotalEngreso
            // 
            this.btnTotalEngreso.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalEngreso.Image = global::Prestamos.Properties.Resources.money;
            this.btnTotalEngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalEngreso.Location = new System.Drawing.Point(475, 65);
            this.btnTotalEngreso.Name = "btnTotalEngreso";
            this.btnTotalEngreso.Size = new System.Drawing.Size(142, 23);
            this.btnTotalEngreso.TabIndex = 12;
            this.btnTotalEngreso.Text = "Calcular Total Engreso";
            this.btnTotalEngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalEngreso.UseVisualStyleBackColor = true;
            this.btnTotalEngreso.Click += new System.EventHandler(this.btnTotalEngreso_Click);
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Location = new System.Drawing.Point(638, 67);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalEgresos.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Monto Egreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo de Egreso";
            // 
            // gbIngresos
            // 
            this.gbIngresos.Controls.Add(this.btnEliminarIngreso);
            this.gbIngresos.Controls.Add(this.btnAgregarIngreso);
            this.gbIngresos.Controls.Add(this.txtMontoIngreso);
            this.gbIngresos.Controls.Add(this.cmbTipoIngreso);
            this.gbIngresos.Controls.Add(this.btnTotalIngreso);
            this.gbIngresos.Controls.Add(this.txtTotalIngresos);
            this.gbIngresos.Controls.Add(this.label14);
            this.gbIngresos.Controls.Add(this.label13);
            this.gbIngresos.Location = new System.Drawing.Point(23, 380);
            this.gbIngresos.Name = "gbIngresos";
            this.gbIngresos.Size = new System.Drawing.Size(750, 95);
            this.gbIngresos.TabIndex = 2;
            this.gbIngresos.TabStop = false;
            this.gbIngresos.Text = "Ingresos";
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngreso.Image = global::Prestamos.Properties.Resources.delete;
            this.btnEliminarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(226, 66);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarIngreso.TabIndex = 12;
            this.btnEliminarIngreso.Text = "Eliminar";
            this.btnEliminarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarIngreso.UseVisualStyleBackColor = true;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngreso.Image = global::Prestamos.Properties.Resources.add;
            this.btnAgregarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarIngreso.Location = new System.Drawing.Point(16, 66);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIngreso.TabIndex = 10;
            this.btnAgregarIngreso.Text = "Agregar";
            this.btnAgregarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // txtMontoIngreso
            // 
            this.txtMontoIngreso.Location = new System.Drawing.Point(337, 31);
            this.txtMontoIngreso.Name = "txtMontoIngreso";
            this.txtMontoIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtMontoIngreso.TabIndex = 9;
            // 
            // cmbTipoIngreso
            // 
            this.cmbTipoIngreso.FormattingEnabled = true;
            this.cmbTipoIngreso.Location = new System.Drawing.Point(98, 30);
            this.cmbTipoIngreso.Name = "cmbTipoIngreso";
            this.cmbTipoIngreso.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoIngreso.TabIndex = 8;
            // 
            // btnTotalIngreso
            // 
            this.btnTotalIngreso.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalIngreso.Image = global::Prestamos.Properties.Resources.money;
            this.btnTotalIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalIngreso.Location = new System.Drawing.Point(464, 66);
            this.btnTotalIngreso.Name = "btnTotalIngreso";
            this.btnTotalIngreso.Size = new System.Drawing.Size(142, 23);
            this.btnTotalIngreso.TabIndex = 7;
            this.btnTotalIngreso.Text = "Calcular Total Ingreso";
            this.btnTotalIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalIngreso.UseVisualStyleBackColor = true;
            this.btnTotalIngreso.Click += new System.EventHandler(this.btnTotalIngreso_Click);
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(637, 66);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.ReadOnly = true;
            this.txtTotalIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIngresos.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Monto Ingreso";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tipo Ingreso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Prestamos.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(23, 662);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Prestamos.Properties.Resources.cancel;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(701, 653);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvEgreso
            // 
            this.dgvEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgreso.Location = new System.Drawing.Point(23, 224);
            this.dgvEgreso.Name = "dgvEgreso";
            this.dgvEgreso.Size = new System.Drawing.Size(748, 150);
            this.dgvEgreso.TabIndex = 6;
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngreso.Location = new System.Drawing.Point(22, 481);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.Size = new System.Drawing.Size(749, 166);
            this.dgvIngreso.TabIndex = 7;
            // 
            // frmEvaluacionCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 689);
            this.Controls.Add(this.dgvIngreso);
            this.Controls.Add(this.dgvEgreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbIngresos);
            this.Controls.Add(this.gbEgresos);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmEvaluacionCredito";
            this.Text = "EvaluacionCredito";
            this.Load += new System.EventHandler(this.frmEvaluacionCredito_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbEgresos.ResumeLayout(false);
            this.gbEgresos.PerformLayout();
            this.gbIngresos.ResumeLayout(false);
            this.gbIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbEgresos;
        private System.Windows.Forms.GroupBox gbIngresos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarEgreso;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTotalEngreso;
        private System.Windows.Forms.Button btnTotalIngreso;
        private System.Windows.Forms.TextBox txtMontoEgreso;
        private System.Windows.Forms.ComboBox cmbTipoEgreso;
        private System.Windows.Forms.TextBox txtMontoIngreso;
        private System.Windows.Forms.ComboBox cmbTipoIngreso;
        private System.Windows.Forms.DataGridView dgvEgreso;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.Button btnAgregarEgreso;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnInformconf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtInformconf;
    }
}