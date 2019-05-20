namespace Prestamos
{
    partial class frmCliente
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
            this.lblNumCliente = new System.Windows.Forms.Label();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbDatoslabrales = new System.Windows.Forms.GroupBox();
            this.lblLugarDeTrabajo = new System.Windows.Forms.Label();
            this.lblAntiguedadLaboral = new System.Windows.Forms.Label();
            this.lblInformconf = new System.Windows.Forms.Label();
            this.rdbInformconfNO = new System.Windows.Forms.RadioButton();
            this.rdbInformConfSI = new System.Windows.Forms.RadioButton();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtLugarTrabajo = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbDatoslabrales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumCliente
            // 
            this.lblNumCliente.AutoSize = true;
            this.lblNumCliente.Location = new System.Drawing.Point(49, 42);
            this.lblNumCliente.Name = "lblNumCliente";
            this.lblNumCliente.Size = new System.Drawing.Size(67, 13);
            this.lblNumCliente.TabIndex = 0;
            this.lblNumCliente.Text = "Num. Cliente";
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Location = new System.Drawing.Point(187, 35);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(170, 20);
            this.txtNumCliente.TabIndex = 1;
            this.txtNumCliente.Leave += new System.EventHandler(this.txtNumCliente_Leave);
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(49, 99);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(85, 13);
            this.lbDocumento.TabIndex = 2;
            this.lbDocumento.Text = "Nro. Documento";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(49, 152);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(49, 178);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(63, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(49, 205);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(49, 232);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(413, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 123);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // grbDatoslabrales
            // 
            this.grbDatoslabrales.Controls.Add(this.lblAntiguedad);
            this.grbDatoslabrales.Controls.Add(this.txtAntiguedad);
            this.grbDatoslabrales.Controls.Add(this.txtLugarTrabajo);
            this.grbDatoslabrales.Controls.Add(this.rdbInformConfSI);
            this.grbDatoslabrales.Controls.Add(this.rdbInformconfNO);
            this.grbDatoslabrales.Controls.Add(this.lblInformconf);
            this.grbDatoslabrales.Controls.Add(this.lblAntiguedadLaboral);
            this.grbDatoslabrales.Controls.Add(this.lblLugarDeTrabajo);
            this.grbDatoslabrales.Location = new System.Drawing.Point(51, 252);
            this.grbDatoslabrales.Name = "grbDatoslabrales";
            this.grbDatoslabrales.Size = new System.Drawing.Size(484, 142);
            this.grbDatoslabrales.TabIndex = 8;
            this.grbDatoslabrales.TabStop = false;
            // 
            // lblLugarDeTrabajo
            // 
            this.lblLugarDeTrabajo.AutoSize = true;
            this.lblLugarDeTrabajo.Location = new System.Drawing.Point(16, 20);
            this.lblLugarDeTrabajo.Name = "lblLugarDeTrabajo";
            this.lblLugarDeTrabajo.Size = new System.Drawing.Size(88, 13);
            this.lblLugarDeTrabajo.TabIndex = 0;
            this.lblLugarDeTrabajo.Text = "Lugar de Trabajo";
            // 
            // lblAntiguedadLaboral
            // 
            this.lblAntiguedadLaboral.AutoSize = true;
            this.lblAntiguedadLaboral.Location = new System.Drawing.Point(16, 63);
            this.lblAntiguedadLaboral.Name = "lblAntiguedadLaboral";
            this.lblAntiguedadLaboral.Size = new System.Drawing.Size(95, 13);
            this.lblAntiguedadLaboral.TabIndex = 1;
            this.lblAntiguedadLaboral.Text = "Antigüedad laboral";
            // 
            // lblInformconf
            // 
            this.lblInformconf.AutoSize = true;
            this.lblInformconf.Location = new System.Drawing.Point(16, 106);
            this.lblInformconf.Name = "lblInformconf";
            this.lblInformconf.Size = new System.Drawing.Size(104, 13);
            this.lblInformconf.TabIndex = 2;
            this.lblInformconf.Text = "Figura en Informconf";
            // 
            // rdbInformconfNO
            // 
            this.rdbInformconfNO.AutoSize = true;
            this.rdbInformconfNO.Location = new System.Drawing.Point(166, 106);
            this.rdbInformconfNO.Name = "rdbInformconfNO";
            this.rdbInformconfNO.Size = new System.Drawing.Size(41, 17);
            this.rdbInformconfNO.TabIndex = 11;
            this.rdbInformconfNO.TabStop = true;
            this.rdbInformconfNO.Text = "NO";
            this.rdbInformconfNO.UseVisualStyleBackColor = true;
            // 
            // rdbInformConfSI
            // 
            this.rdbInformConfSI.AutoSize = true;
            this.rdbInformConfSI.Location = new System.Drawing.Point(271, 106);
            this.rdbInformConfSI.Name = "rdbInformConfSI";
            this.rdbInformConfSI.Size = new System.Drawing.Size(35, 17);
            this.rdbInformConfSI.TabIndex = 12;
            this.rdbInformConfSI.TabStop = true;
            this.rdbInformConfSI.Text = "SI";
            this.rdbInformConfSI.UseVisualStyleBackColor = true;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(49, 72);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 9;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(187, 64);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(170, 21);
            this.cmbTipoDocumento.TabIndex = 2;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(187, 92);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(170, 20);
            this.txtNroDocumento.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(187, 145);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(170, 20);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(49, 126);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(187, 118);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(170, 21);
            this.cmbSexo.TabIndex = 4;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(187, 171);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(187, 198);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(187, 225);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(184, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 13);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Formulario Clientes";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 426);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(204, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(431, 426);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtLugarTrabajo
            // 
            this.txtLugarTrabajo.Location = new System.Drawing.Point(136, 13);
            this.txtLugarTrabajo.Name = "txtLugarTrabajo";
            this.txtLugarTrabajo.Size = new System.Drawing.Size(170, 20);
            this.txtLugarTrabajo.TabIndex = 9;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(136, 56);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(170, 20);
            this.txtAntiguedad.TabIndex = 10;
            this.txtAntiguedad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(325, 63);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(38, 13);
            this.lblAntiguedad.TabIndex = 7;
            this.lblAntiguedad.Text = "Meses";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(322, 426);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 484);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.grbDatoslabrales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.txtNumCliente);
            this.Controls.Add(this.lblNumCliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbDatoslabrales.ResumeLayout(false);
            this.grbDatoslabrales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCliente;
        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbDatoslabrales;
        private System.Windows.Forms.RadioButton rdbInformConfSI;
        private System.Windows.Forms.RadioButton rdbInformconfNO;
        private System.Windows.Forms.Label lblInformconf;
        private System.Windows.Forms.Label lblAntiguedadLaboral;
        private System.Windows.Forms.Label lblLugarDeTrabajo;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtLugarTrabajo;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Button btnBorrar;
    }
}