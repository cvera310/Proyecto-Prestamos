namespace Prestamos
{
    partial class frmTipoPrestamo
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvTipoPrestamo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "%";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(228, 297);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(33, 20);
            this.txtInteres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Interes base";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 338);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(174, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 297);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(117, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(201, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(32, 253);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvTipoPrestamo
            // 
            this.dgvTipoPrestamo.AllowUserToAddRows = false;
            this.dgvTipoPrestamo.AllowUserToDeleteRows = false;
            this.dgvTipoPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPrestamo.Location = new System.Drawing.Point(37, 29);
            this.dgvTipoPrestamo.Name = "dgvTipoPrestamo";
            this.dgvTipoPrestamo.ReadOnly = true;
            this.dgvTipoPrestamo.Size = new System.Drawing.Size(240, 187);
            this.dgvTipoPrestamo.TabIndex = 18;
            this.dgvTipoPrestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPrestamo_CellClick);
            // 
            // frmTipoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTipoPrestamo);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "frmTipoPrestamo";
            this.Text = "Tipo de prestamo";
            this.Load += new System.EventHandler(this.frmTipoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTipoPrestamo;
    }
}