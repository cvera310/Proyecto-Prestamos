namespace Prestamos
{
    partial class frmRecibo
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
            this.crvRecibo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRecibo
            // 
            this.crvRecibo.ActiveViewIndex = -1;
            this.crvRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRecibo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRecibo.DisplayToolbar = false;
            this.crvRecibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRecibo.Location = new System.Drawing.Point(20, 60);
            this.crvRecibo.Name = "crvRecibo";
            this.crvRecibo.Size = new System.Drawing.Size(944, 489);
            this.crvRecibo.TabIndex = 0;
            this.crvRecibo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.crvRecibo);
            this.MinimizeBox = false;
            this.Name = "frmRecibo";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvRecibo;
    }
}