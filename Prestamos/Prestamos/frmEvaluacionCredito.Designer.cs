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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEgresos = new System.Windows.Forms.GroupBox();
            this.btnTotalEngreso = new System.Windows.Forms.Button();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.txtAlimentacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbIngresos = new System.Windows.Forms.GroupBox();
            this.txtIngresoExtra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTotalIngreso = new System.Windows.Forms.Button();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbEgresos.SuspendLayout();
            this.gbIngresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cmbCliente);
            this.gbCliente.Controls.Add(this.cmbSexo);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.cmbTipoDoc);
            this.gbCliente.Controls.Add(this.dtpFechaNac);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.txtRazonSocial);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Location = new System.Drawing.Point(22, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(750, 135);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(77, 20);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 16;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(617, 10);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(92, 21);
            this.cmbSexo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sexo";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(374, 102);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDoc.TabIndex = 13;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(374, 57);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(154, 20);
            this.dtpFechaNac.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(374, 13);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Doc.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Nac.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 102);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(89, 58);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // gbEgresos
            // 
            this.gbEgresos.Controls.Add(this.btnTotalEngreso);
            this.gbEgresos.Controls.Add(this.txtTotalEgresos);
            this.gbEgresos.Controls.Add(this.txtOtros);
            this.gbEgresos.Controls.Add(this.txtTransporte);
            this.gbEgresos.Controls.Add(this.txtAlquiler);
            this.gbEgresos.Controls.Add(this.txtServicios);
            this.gbEgresos.Controls.Add(this.txtAlimentacion);
            this.gbEgresos.Controls.Add(this.label12);
            this.gbEgresos.Controls.Add(this.label11);
            this.gbEgresos.Controls.Add(this.label10);
            this.gbEgresos.Controls.Add(this.label9);
            this.gbEgresos.Controls.Add(this.label8);
            this.gbEgresos.Location = new System.Drawing.Point(22, 164);
            this.gbEgresos.Name = "gbEgresos";
            this.gbEgresos.Size = new System.Drawing.Size(750, 103);
            this.gbEgresos.TabIndex = 1;
            this.gbEgresos.TabStop = false;
            this.gbEgresos.Text = "Egresos";
            // 
            // btnTotalEngreso
            // 
            this.btnTotalEngreso.Location = new System.Drawing.Point(490, 60);
            this.btnTotalEngreso.Name = "btnTotalEngreso";
            this.btnTotalEngreso.Size = new System.Drawing.Size(142, 23);
            this.btnTotalEngreso.TabIndex = 12;
            this.btnTotalEngreso.Text = "Calcular Total Engreso";
            this.btnTotalEngreso.UseVisualStyleBackColor = true;
            this.btnTotalEngreso.Click += new System.EventHandler(this.btnTotalEngreso_Click);
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Location = new System.Drawing.Point(644, 62);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalEgresos.TabIndex = 11;
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(546, 16);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(100, 20);
            this.txtOtros.TabIndex = 9;
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(339, 59);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 8;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(339, 16);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(100, 20);
            this.txtAlquiler.TabIndex = 7;
            // 
            // txtServicios
            // 
            this.txtServicios.Location = new System.Drawing.Point(125, 55);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(100, 20);
            this.txtServicios.TabIndex = 6;
            // 
            // txtAlimentacion
            // 
            this.txtAlimentacion.Location = new System.Drawing.Point(125, 13);
            this.txtAlimentacion.Name = "txtAlimentacion";
            this.txtAlimentacion.Size = new System.Drawing.Size(100, 20);
            this.txtAlimentacion.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Otros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Transporte";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Alquiler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Servicios Basicos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Alimentacion";
            // 
            // gbIngresos
            // 
            this.gbIngresos.Controls.Add(this.txtIngresoExtra);
            this.gbIngresos.Controls.Add(this.label15);
            this.gbIngresos.Controls.Add(this.btnTotalIngreso);
            this.gbIngresos.Controls.Add(this.cmbTipoPago);
            this.gbIngresos.Controls.Add(this.txtTotalIngresos);
            this.gbIngresos.Controls.Add(this.txtSalario);
            this.gbIngresos.Controls.Add(this.label14);
            this.gbIngresos.Controls.Add(this.label13);
            this.gbIngresos.Location = new System.Drawing.Point(22, 273);
            this.gbIngresos.Name = "gbIngresos";
            this.gbIngresos.Size = new System.Drawing.Size(750, 105);
            this.gbIngresos.TabIndex = 2;
            this.gbIngresos.TabStop = false;
            this.gbIngresos.Text = "Ingresos";
            // 
            // txtIngresoExtra
            // 
            this.txtIngresoExtra.Location = new System.Drawing.Point(353, 27);
            this.txtIngresoExtra.Name = "txtIngresoExtra";
            this.txtIngresoExtra.Size = new System.Drawing.Size(100, 20);
            this.txtIngresoExtra.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(252, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Ingresos Extras";
            // 
            // btnTotalIngreso
            // 
            this.btnTotalIngreso.Location = new System.Drawing.Point(490, 72);
            this.btnTotalIngreso.Name = "btnTotalIngreso";
            this.btnTotalIngreso.Size = new System.Drawing.Size(142, 23);
            this.btnTotalIngreso.TabIndex = 7;
            this.btnTotalIngreso.Text = "Calcular Total Ingreso";
            this.btnTotalIngreso.UseVisualStyleBackColor = true;
            this.btnTotalIngreso.Click += new System.EventHandler(this.btnTotalIngreso_Click);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(89, 66);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPago.TabIndex = 6;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(644, 74);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIngresos.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(89, 28);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tipo Pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Salario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(22, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(136, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(697, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(262, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmEvaluacionCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbEgresos;
        private System.Windows.Forms.GroupBox gbIngresos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtServicios;
        private System.Windows.Forms.TextBox txtAlimentacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnTotalEngreso;
        private System.Windows.Forms.Button btnTotalIngreso;
        private System.Windows.Forms.TextBox txtIngresoExtra;
        private System.Windows.Forms.Label label15;
    }
}