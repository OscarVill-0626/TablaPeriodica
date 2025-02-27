namespace TablaPeriodica
{
    partial class Ta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ta));
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_edoOx = new System.Windows.Forms.Label();
            this.Txt_nomb = new System.Windows.Forms.Label();
            this.Txt_edoOxE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Location = new System.Drawing.Point(13, 43);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAt.TabIndex = 0;
            this.Txt_numAt.Text = "73";
            this.Txt_numAt.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(81, 77);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(199, 135);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Ta";
            // 
            // Txt_edoOx
            // 
            this.Txt_edoOx.AutoSize = true;
            this.Txt_edoOx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_edoOx.Location = new System.Drawing.Point(202, 43);
            this.Txt_edoOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_edoOx.Name = "Txt_edoOx";
            this.Txt_edoOx.Size = new System.Drawing.Size(93, 20);
            this.Txt_edoOx.TabIndex = 2;
            this.Txt_edoOx.Text = "+1+2+3+4";
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.AutoSize = true;
            this.Txt_nomb.Location = new System.Drawing.Point(129, 212);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(97, 25);
            this.Txt_nomb.TabIndex = 3;
            this.Txt_nomb.Text = "Tantanio";
            // 
            // Txt_edoOxE
            // 
            this.Txt_edoOxE.AutoSize = true;
            this.Txt_edoOxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxE.Location = new System.Drawing.Point(289, 43);
            this.Txt_edoOxE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_edoOxE.Name = "Txt_edoOxE";
            this.Txt_edoOxE.Size = new System.Drawing.Size(30, 20);
            this.Txt_edoOxE.TabIndex = 4;
            this.Txt_edoOxE.Text = "+5";
            // 
            // Ta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(391, 258);
            this.Controls.Add(this.Txt_edoOxE);
            this.Controls.Add(this.Txt_nomb);
            this.Controls.Add(this.Txt_edoOx);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ta";
            this.Text = "Ta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_edoOx;
        private System.Windows.Forms.Label Txt_nomb;
        private System.Windows.Forms.Label Txt_edoOxE;
    }
}