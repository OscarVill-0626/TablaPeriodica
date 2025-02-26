namespace TablaPeriodica
{
    partial class Rb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rb));
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_smbQu = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_edoOx = new System.Windows.Forms.Label();
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_nom.Location = new System.Drawing.Point(166, 234);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(84, 25);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Rubidio";
            // 
            // Txt_smbQu
            // 
            this.Txt_smbQu.AutoSize = true;
            this.Txt_smbQu.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_smbQu.Location = new System.Drawing.Point(105, 88);
            this.Txt_smbQu.Name = "Txt_smbQu";
            this.Txt_smbQu.Size = new System.Drawing.Size(213, 135);
            this.Txt_smbQu.TabIndex = 1;
            this.Txt_smbQu.Text = "Rb";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(12, 24);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAt.TabIndex = 2;
            this.Txt_numAt.Text = "37";
            // 
            // Txt_edoOx
            // 
            this.Txt_edoOx.AutoSize = true;
            this.Txt_edoOx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOx.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Txt_edoOx.Location = new System.Drawing.Point(337, 24);
            this.Txt_edoOx.Name = "Txt_edoOx";
            this.Txt_edoOx.Size = new System.Drawing.Size(32, 25);
            this.Txt_edoOx.TabIndex = 3;
            this.Txt_edoOx.Text = "-1";
            this.Txt_edoOx.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_edoOxi.Location = new System.Drawing.Point(366, 24);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(37, 25);
            this.Txt_edoOxi.TabIndex = 4;
            this.Txt_edoOxi.Text = "+1";
            // 
            // Rb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(433, 304);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_edoOx);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_smbQu);
            this.Controls.Add(this.Txt_nom);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rb";
            this.Text = "Rb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_smbQu;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_edoOx;
        private System.Windows.Forms.Label Txt_edoOxi;
    }
}