namespace TablaPeriodica
{
    partial class Os
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Os));
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_edoOxiE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(250, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(34, 23);
            this.Txt_numAt.TabIndex = 0;
            this.Txt_numAt.Text = "76";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(81, -2);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(172, 116);
            this.Txt_smbQui.TabIndex = 2;
            this.Txt_smbQui.Text = "Os";
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.Location = new System.Drawing.Point(137, 106);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(71, 23);
            this.Txt_nom.TabIndex = 3;
            this.Txt_nom.Text = "Osmio";
            // 
            // Txt_edoOxiE
            // 
            this.Txt_edoOxiE.AutoSize = true;
            this.Txt_edoOxiE.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxiE.Location = new System.Drawing.Point(0, 137);
            this.Txt_edoOxiE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_edoOxiE.Name = "Txt_edoOxiE";
            this.Txt_edoOxiE.Size = new System.Drawing.Size(340, 112);
            this.Txt_edoOxiE.TabIndex = 4;
            this.Txt_edoOxiE.Text = resources.GetString("Txt_edoOxiE.Text");
            // 
            // Os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(335, 258);
            this.Controls.Add(this.Txt_edoOxiE);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Os";
            this.Text = "Os";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_edoOxiE;
    }
}