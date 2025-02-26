namespace TablaPeriodica
{
    partial class Fe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fe));
            this.Txt_numAto = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_EsOx = new System.Windows.Forms.Label();
            this.EsO = new System.Windows.Forms.Label();
            this.EsOxi = new System.Windows.Forms.Label();
            this.Txt_oxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_numAto
            // 
            this.Txt_numAto.AutoSize = true;
            this.Txt_numAto.Location = new System.Drawing.Point(13, 60);
            this.Txt_numAto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAto.Name = "Txt_numAto";
            this.Txt_numAto.Size = new System.Drawing.Size(32, 22);
            this.Txt_numAto.TabIndex = 0;
            this.Txt_numAto.Text = "26";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(81, 95);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(199, 135);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Fe";
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Location = new System.Drawing.Point(148, 230);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(65, 22);
            this.Txt_nom.TabIndex = 2;
            this.Txt_nom.Text = "Hierro";
            // 
            // Txt_EsOx
            // 
            this.Txt_EsOx.AutoSize = true;
            this.Txt_EsOx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EsOx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_EsOx.Location = new System.Drawing.Point(183, 60);
            this.Txt_EsOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_EsOx.Name = "Txt_EsOx";
            this.Txt_EsOx.Size = new System.Drawing.Size(30, 20);
            this.Txt_EsOx.TabIndex = 3;
            this.Txt_EsOx.Text = "+1";
            // 
            // EsO
            // 
            this.EsO.AutoSize = true;
            this.EsO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsO.Location = new System.Drawing.Point(211, 60);
            this.EsO.Name = "EsO";
            this.EsO.Size = new System.Drawing.Size(51, 20);
            this.EsO.TabIndex = 4;
            this.EsO.Text = "+2+3";
            // 
            // EsOxi
            // 
            this.EsOxi.AutoSize = true;
            this.EsOxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsOxi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EsOxi.Location = new System.Drawing.Point(257, 60);
            this.EsOxi.Name = "EsOxi";
            this.EsOxi.Size = new System.Drawing.Size(102, 20);
            this.EsOxi.TabIndex = 5;
            this.EsOxi.Text = "+4+5     +7";
            this.EsOxi.Click += new System.EventHandler(this.label6_Click);
            // 
            // Txt_oxi
            // 
            this.Txt_oxi.AutoSize = true;
            this.Txt_oxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_oxi.Location = new System.Drawing.Point(303, 60);
            this.Txt_oxi.Name = "Txt_oxi";
            this.Txt_oxi.Size = new System.Drawing.Size(30, 20);
            this.Txt_oxi.TabIndex = 6;
            this.Txt_oxi.Text = "+6";
            // 
            // Fe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(371, 291);
            this.Controls.Add(this.Txt_oxi);
            this.Controls.Add(this.EsOxi);
            this.Controls.Add(this.EsO);
            this.Controls.Add(this.Txt_EsOx);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fe";
            this.Text = "Fe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_numAto;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_EsOx;
        private System.Windows.Forms.Label EsO;
        private System.Windows.Forms.Label EsOxi;
        private System.Windows.Forms.Label Txt_oxi;
    }
}