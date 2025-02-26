namespace TablaPeriodica
{
    partial class Sc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sc));
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_numAto = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_edoOx = new System.Windows.Forms.Label();
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.Location = new System.Drawing.Point(180, 255);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(101, 25);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Escandio";
            // 
            // Txt_numAto
            // 
            this.Txt_numAto.AutoSize = true;
            this.Txt_numAto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAto.Location = new System.Drawing.Point(13, 32);
            this.Txt_numAto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAto.Name = "Txt_numAto";
            this.Txt_numAto.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAto.TabIndex = 1;
            this.Txt_numAto.Text = "21";
            this.Txt_numAto.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(130, 120);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(199, 135);
            this.Txt_smbQui.TabIndex = 2;
            this.Txt_smbQui.Text = "Sc";
            // 
            // Txt_edoOx
            // 
            this.Txt_edoOx.AutoSize = true;
            this.Txt_edoOx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_edoOx.Location = new System.Drawing.Point(344, 32);
            this.Txt_edoOx.Name = "Txt_edoOx";
            this.Txt_edoOx.Size = new System.Drawing.Size(58, 25);
            this.Txt_edoOx.TabIndex = 3;
            this.Txt_edoOx.Text = "+1+2";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Location = new System.Drawing.Point(396, 32);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(35, 25);
            this.Txt_edoOxi.TabIndex = 4;
            this.Txt_edoOxi.Text = "+3";
            // 
            // Sc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_edoOx);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAto);
            this.Controls.Add(this.Txt_nom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sc";
            this.Text = "Sc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_numAto;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_edoOx;
        private System.Windows.Forms.Label Txt_edoOxi;
    }
}