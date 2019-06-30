namespace Prestamos
{
    partial class frmFormaPagoCobranza
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.TipoCheque = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numeroCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCheques);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cheques";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCheques
            // 
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoCheque,
            this.numeroCheque,
            this.fechaCheque,
            this.montoCheque});
            this.dgvCheques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheques.Location = new System.Drawing.Point(3, 3);
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.Size = new System.Drawing.Size(464, 220);
            this.dgvCheques.TabIndex = 0;
            this.dgvCheques.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheques_CellEndEdit);
            this.dgvCheques.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCheques_CellValidating);
            this.dgvCheques.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvCheques_DefaultValuesNeeded);
            this.dgvCheques.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCheques_EditingControlShowing);
            this.dgvCheques.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCheques_KeyDown);
            this.dgvCheques.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCheques_KeyPress);
            // 
            // TipoCheque
            // 
            this.TipoCheque.AutoComplete = false;
            this.TipoCheque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoCheque.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TipoCheque.HeaderText = "Tipo de cheque";
            this.TipoCheque.Name = "TipoCheque";
            this.TipoCheque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numeroCheque
            // 
            this.numeroCheque.HeaderText = "Numero de cheque";
            this.numeroCheque.MaxInputLength = 13;
            this.numeroCheque.Name = "numeroCheque";
            // 
            // fechaCheque
            // 
            this.fechaCheque.HeaderText = "Fecha del cheque";
            this.fechaCheque.MaxInputLength = 10;
            this.fechaCheque.Name = "fechaCheque";
            // 
            // montoCheque
            // 
            this.montoCheque.HeaderText = "Monto";
            this.montoCheque.MaxInputLength = 10;
            this.montoCheque.Name = "montoCheque";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtEfectivo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Efectivo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(F3 para obtener monto total)";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(53, 14);
            this.txtEfectivo.MaxLength = 8;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 1;
            this.txtEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEfectivo_KeyDown);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(404, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmFormaPagoCobranza
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 348);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaPagoCobranza";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Load += new System.EventHandler(this.frmFormaPagoCobranza_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCheque;
    }
}