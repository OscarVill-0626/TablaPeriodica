namespace TablaPeriodica
{
    partial class Zr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zr));
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_edoOx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.Location = new System.Drawing.Point(102, 111);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(92, 23);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Zirconio";
            this.Txt_nom.Click += new System.EventHandler(this.Txt_nom_Click);
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(69, -3);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(157, 116);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Zr";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(205, 7);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(35, 23);
            this.Txt_numAt.TabIndex = 2;
            this.Txt_numAt.Text = "40";
            // 
            // Txt_edoOx
            // 
            this.Txt_edoOx.AutoSize = true;
            this.Txt_edoOx.Location = new System.Drawing.Point(4, 134);
            this.Txt_edoOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_edoOx.Name = "Txt_edoOx";
            this.Txt_edoOx.Size = new System.Drawing.Size(340, 112);
            this.Txt_edoOx.TabIndex = 4;
            this.Txt_edoOx.Text = resources.GetString("Txt_edoOx.Text");
            // 
            // Zr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(344, 258);
            this.Controls.Add(this.Txt_edoOx);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_nom);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Zr";
            this.Text = "Zr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_edoOx;
    }
}