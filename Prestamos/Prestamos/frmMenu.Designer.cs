namespace Prestamos
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobarCreditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMonedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.solicitudToolStripMenuItem,
            this.prestamoToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuario_Click);
            // 
            // solicitudToolStripMenuItem
            // 
            this.solicitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.aprobarCreditosToolStripMenuItem});
            this.solicitudToolStripMenuItem.Name = "solicitudToolStripMenuItem";
            this.solicitudToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.solicitudToolStripMenuItem.Text = "Solicitud";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Solicitud de Credito";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // aprobarCreditosToolStripMenuItem
            // 
            this.aprobarCreditosToolStripMenuItem.Name = "aprobarCreditosToolStripMenuItem";
            this.aprobarCreditosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.aprobarCreditosToolStripMenuItem.Text = "Aprobar Creditos";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.tipoDePrestamoToolStripMenuItem});
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.tsmPrestamo_Click);
            // 
            // tipoDePrestamoToolStripMenuItem
            // 
            this.tipoDePrestamoToolStripMenuItem.Name = "tipoDePrestamoToolStripMenuItem";
            this.tipoDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tipoDePrestamoToolStripMenuItem.Text = "Tipo de prestamo";
            this.tipoDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.tsmTipoPrestamo_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClienteToolStripMenuItem,
            this.registroDeEmpleadoToolStripMenuItem,
            this.registroDeMonedaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.reportesToolStripMenuItem.Text = "Registros";
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registroDeClienteToolStripMenuItem.Text = "Registro de Cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // registroDeEmpleadoToolStripMenuItem
            // 
            this.registroDeEmpleadoToolStripMenuItem.Name = "registroDeEmpleadoToolStripMenuItem";
            this.registroDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registroDeEmpleadoToolStripMenuItem.Text = "Registro de Empleado";
            // 
            // registroDeMonedaToolStripMenuItem
            // 
            this.registroDeMonedaToolStripMenuItem.Name = "registroDeMonedaToolStripMenuItem";
            this.registroDeMonedaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registroDeMonedaToolStripMenuItem.Text = "Registro de Moneda";
            this.registroDeMonedaToolStripMenuItem.Click += new System.EventHandler(this.registroDeMonedaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ayudaToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.acercaDeToolStripMenuItem.Text = "Prestamos Aprobados";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(129, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(216, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Sistema de Gestión para Prestamos";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblusuario});
            this.statusStrip2.Location = new System.Drawing.Point(20, 596);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel2.Text = "lblFecha";
            // 
            // lblusuario
            // 
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lblusuario.Size = new System.Drawing.Size(993, 17);
            this.lblusuario.Spring = true;
            this.lblusuario.Text = "usuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::Prestamos.Properties.Resources.logo;
            pictureBox1.Location = new System.Drawing.Point(344, 296);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(517, 171);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 638);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Resizable = false;
            this.Text = "SYGESPRE";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tipoDePrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprobarCreditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeMonedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblusuario;
    }
}