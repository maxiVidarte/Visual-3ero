namespace FormsCuentaOffShore
{
    partial class FrmCuentaOffShore
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
            this.cboBoxParaiso = new System.Windows.Forms.ComboBox();
            this.lblParaiso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBoxParaiso
            // 
            this.cboBoxParaiso.FormattingEnabled = true;
            this.cboBoxParaiso.Location = new System.Drawing.Point(130, 168);
            this.cboBoxParaiso.Name = "cboBoxParaiso";
            this.cboBoxParaiso.Size = new System.Drawing.Size(121, 21);
            this.cboBoxParaiso.TabIndex = 6;
            // 
            // lblParaiso
            // 
            this.lblParaiso.AutoSize = true;
            this.lblParaiso.Location = new System.Drawing.Point(26, 171);
            this.lblParaiso.Name = "lblParaiso";
            this.lblParaiso.Size = new System.Drawing.Size(72, 13);
            this.lblParaiso.TabIndex = 7;
            this.lblParaiso.Text = "Paraiso Fiscal";
            // 
            // FrmCuentaOffShore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblParaiso);
            this.Controls.Add(this.cboBoxParaiso);
            this.Name = "FrmCuentaOffShore";
            this.Text = "FrmCuentaOffShore";
            this.Load += new System.EventHandler(this.FrmCuentaOffShore_Load);
            this.Controls.SetChildIndex(this.txtNroCuenta, 0);
            this.Controls.SetChildIndex(this.txtTitular, 0);
            this.Controls.SetChildIndex(this.cboBoxParaiso, 0);
            this.Controls.SetChildIndex(this.lblParaiso, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxParaiso;
        private System.Windows.Forms.Label lblParaiso;
    }
}