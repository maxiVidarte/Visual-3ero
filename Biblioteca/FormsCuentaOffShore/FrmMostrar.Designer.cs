namespace FormsCuentaOffShore
{
    partial class FrmMostrar
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
            this.LstMostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstMostrar
            // 
            this.LstMostrar.ForeColor = System.Drawing.Color.Red;
            this.LstMostrar.FormattingEnabled = true;
            this.LstMostrar.Location = new System.Drawing.Point(12, 12);
            this.LstMostrar.Name = "LstMostrar";
            this.LstMostrar.Size = new System.Drawing.Size(260, 238);
            this.LstMostrar.TabIndex = 0;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LstMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstMostrar;
    }
}