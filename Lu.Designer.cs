namespace TablaPeriodica
{
    partial class Lu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lu));
            this.Txt_nomb = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_edoOx = new System.Windows.Forms.Label();
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.AutoSize = true;
            this.Txt_nomb.Location = new System.Drawing.Point(171, 249);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(82, 25);
            this.Txt_nomb.TabIndex = 0;
            this.Txt_nomb.Text = "Lutecio";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(124, 99);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(193, 135);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Lu";
            // 
            // Txt_edoOx
            // 
            this.Txt_edoOx.AutoSize = true;
            this.Txt_edoOx.Location = new System.Drawing.Point(371, 53);
            this.Txt_edoOx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_edoOx.Name = "Txt_edoOx";
            this.Txt_edoOx.Size = new System.Drawing.Size(37, 25);
            this.Txt_edoOx.TabIndex = 2;
            this.Txt_edoOx.Text = "+3";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_edoOxi.Location = new System.Drawing.Point(339, 53);
            this.Txt_edoOxi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(37, 25);
            this.Txt_edoOxi.TabIndex = 3;
            this.Txt_edoOxi.Text = "+2";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Location = new System.Drawing.Point(14, 53);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAt.TabIndex = 4;
            this.Txt_numAt.Text = "71";
            this.Txt_numAt.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 324);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_edoOx);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_nomb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Lu";
            this.Text = "Lu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nomb;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_edoOx;
        private System.Windows.Forms.Label Txt_edoOxi;
        private System.Windows.Forms.Label Txt_numAt;
    }
}