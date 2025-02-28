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
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_nom.Location = new System.Drawing.Point(111, 121);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(91, 23);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Escandio";
            // 
            // Txt_numAto
            // 
            this.Txt_numAto.AutoSize = true;
            this.Txt_numAto.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_numAto.Location = new System.Drawing.Point(241, -1);
            this.Txt_numAto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAto.Name = "Txt_numAto";
            this.Txt_numAto.Size = new System.Drawing.Size(30, 23);
            this.Txt_numAto.TabIndex = 1;
            this.Txt_numAto.Text = "21";
            this.Txt_numAto.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_smbQui.Location = new System.Drawing.Point(76, -1);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(157, 116);
            this.Txt_smbQui.TabIndex = 2;
            this.Txt_smbQui.Text = "Sc";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_edoOxi.Location = new System.Drawing.Point(1, 145);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(295, 112);
            this.Txt_edoOxi.TabIndex = 4;
            this.Txt_edoOxi.Text = resources.GetString("Txt_edoOxi.Text");
            // 
            // Sc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(296, 269);
            this.Controls.Add(this.Txt_edoOxi);
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
        private System.Windows.Forms.Label Txt_edoOxi;
    }
}