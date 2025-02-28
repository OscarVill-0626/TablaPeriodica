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
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_nom.Location = new System.Drawing.Point(122, 117);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(84, 23);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Rubidio";
            // 
            // Txt_smbQu
            // 
            this.Txt_smbQu.AutoSize = true;
            this.Txt_smbQu.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_smbQu.Location = new System.Drawing.Point(78, 1);
            this.Txt_smbQu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_smbQu.Name = "Txt_smbQu";
            this.Txt_smbQu.Size = new System.Drawing.Size(169, 116);
            this.Txt_smbQu.TabIndex = 1;
            this.Txt_smbQu.Text = "Rb";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(251, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(35, 23);
            this.Txt_numAt.TabIndex = 2;
            this.Txt_numAt.Text = "37";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_edoOxi.Location = new System.Drawing.Point(1, 138);
            this.Txt_edoOxi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(340, 112);
            this.Txt_edoOxi.TabIndex = 4;
            this.Txt_edoOxi.Text = resources.GetString("Txt_edoOxi.Text");
            // 
            // Rb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_smbQu);
            this.Controls.Add(this.Txt_nom);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rb";
            this.Text = "Rb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_smbQu;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_edoOxi;
    }
}