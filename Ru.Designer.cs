namespace TablaPeriodica
{
    partial class Ru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ru));
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_numOx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(245, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(34, 23);
            this.Txt_numAt.TabIndex = 0;
            this.Txt_numAt.Text = "44";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(78, 0);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(169, 116);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Ru";
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.Location = new System.Drawing.Point(123, 108);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(89, 23);
            this.Txt_nom.TabIndex = 3;
            this.Txt_nom.Text = "Rutenio";
            this.Txt_nom.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txt_numOx
            // 
            this.Txt_numOx.AutoSize = true;
            this.Txt_numOx.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numOx.Location = new System.Drawing.Point(1, 132);
            this.Txt_numOx.Name = "Txt_numOx";
            this.Txt_numOx.Size = new System.Drawing.Size(340, 112);
            this.Txt_numOx.TabIndex = 4;
            this.Txt_numOx.Text = resources.GetString("Txt_numOx.Text");
            // 
            // Ru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(341, 255);
            this.Controls.Add(this.Txt_numOx);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ru";
            this.Text = "Ru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_numOx;
    }
}