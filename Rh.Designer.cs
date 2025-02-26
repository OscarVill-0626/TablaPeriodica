namespace TablaPeriodica
{
    partial class Rh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rh));
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_numOx = new System.Windows.Forms.Label();
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_numOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Location = new System.Drawing.Point(14, 18);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAt.TabIndex = 0;
            this.Txt_numAt.Text = "43";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Txt_smbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(92, 44);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(213, 135);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Rh";
            // 
            // Txt_numOx
            // 
            this.Txt_numOx.AutoSize = true;
            this.Txt_numOx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_numOx.Location = new System.Drawing.Point(246, 18);
            this.Txt_numOx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numOx.Name = "Txt_numOx";
            this.Txt_numOx.Size = new System.Drawing.Size(179, 25);
            this.Txt_numOx.TabIndex = 2;
            this.Txt_numOx.Text = "+1+2       +4+5+6";
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Location = new System.Drawing.Point(162, 175);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(67, 25);
            this.Txt_nom.TabIndex = 3;
            this.Txt_nom.Text = "Rodio";
            // 
            // Txt_numOxi
            // 
            this.Txt_numOxi.AutoSize = true;
            this.Txt_numOxi.Location = new System.Drawing.Point(306, 18);
            this.Txt_numOxi.Name = "Txt_numOxi";
            this.Txt_numOxi.Size = new System.Drawing.Size(37, 25);
            this.Txt_numOxi.TabIndex = 4;
            this.Txt_numOxi.Text = "+3";
            this.Txt_numOxi.Click += new System.EventHandler(this.label5_Click);
            // 
            // Rh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(432, 310);
            this.Controls.Add(this.Txt_numOxi);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_numOx);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Rh";
            this.Text = "Rh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_numOx;
        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_numOxi;
    }
}