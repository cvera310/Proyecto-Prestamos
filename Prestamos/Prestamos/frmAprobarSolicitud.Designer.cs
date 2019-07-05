namespace Prestamos
{
    partial class frmAprobarSolicitud
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
            this.grbCobro = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbCobro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCobro
            // 
            this.grbCobro.Controls.Add(this.btnCalcular);
            this.grbCobro.Controls.Add(this.dgvPendientes);
            this.grbCobro.Location = new System.Drawing.Point(32, 106);
            this.grbCobro.Name = "grbCobro";
            this.grbCobro.Size = new System.Drawing.Size(789, 338);
            this.grbCobro.TabIndex = 7;
            this.grbCobro.TabStop = false;
            this.grbCobro.Text = "Solicitudes pendientes de aprobación";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::Prestamos.Properties.Resources.check;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(652, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 34);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Aprobar Solicitud";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvPendientes.Location = new System.Drawing.Point(7, 20);
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
            // frmAprobarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 524);
            this.Controls.Add(this.grbCobro);
            this.Name = "frmAprobarSolicitud";
            this.Text = "Aprobar Solicitud";
            this.Load += new System.EventHandler(this.frmAprobarSolicitud_Load);
            this.grbCobro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCobro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}