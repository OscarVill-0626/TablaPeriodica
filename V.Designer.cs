namespace TablaPeriodica
{
    partial class V
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
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_numOx = new System.Windows.Forms.Label();
            this.Txt_numOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Location = new System.Drawing.Point(106, 223);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(92, 25);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Vanadio";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Location = new System.Drawing.Point(14, 38);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAt.TabIndex = 1;
            this.Txt_numAt.Text = "23";
            this.Txt_numAt.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(88, 88);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(138, 135);
            this.Txt_smbQui.TabIndex = 2;
            this.Txt_smbQui.Text = "V";
            // 
            // Txt_numOx
            // 
            this.Txt_numOx.AutoSize = true;
            this.Txt_numOx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_numOx.Location = new System.Drawing.Point(188, 38);
            this.Txt_numOx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numOx.Name = "Txt_numOx";
            this.Txt_numOx.Size = new System.Drawing.Size(112, 25);
            this.Txt_numOx.TabIndex = 3;
            this.Txt_numOx.Text = "+1+2+3+4";
            // 
            // Txt_numOxi
            // 
            this.Txt_numOxi.AutoSize = true;
            this.Txt_numOxi.Location = new System.Drawing.Point(292, 38);
            this.Txt_numOxi.Name = "Txt_numOxi";
            this.Txt_numOxi.Size = new System.Drawing.Size(37, 25);
            this.Txt_numOxi.TabIndex = 4;
            this.Txt_numOxi.Text = "+5";
            // 
            // V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(365, 290);
            this.Controls.Add(this.Txt_numOxi);
            this.Controls.Add(this.Txt_numOx);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_nom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "V";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_numOx;
        private System.Windows.Forms.Label Txt_numOxi;
    }
}