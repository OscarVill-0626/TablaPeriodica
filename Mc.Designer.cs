namespace TablaPeriodica
{
    partial class Mc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mc));
            this.l115 = new System.Windows.Forms.Label();
            this.mos = new System.Windows.Forms.Label();
            this.moscovio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l115
            // 
            this.l115.AutoSize = true;
            this.l115.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l115.Location = new System.Drawing.Point(223, 9);
            this.l115.Name = "l115";
            this.l115.Size = new System.Drawing.Size(39, 23);
            this.l115.TabIndex = 0;
            this.l115.Text = "115";
            // 
            // mos
            // 
            this.mos.AutoSize = true;
            this.mos.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mos.Location = new System.Drawing.Point(77, 32);
            this.mos.Name = "mos";
            this.mos.Size = new System.Drawing.Size(185, 116);
            this.mos.TabIndex = 0;
            this.mos.Text = "Mc";
            // 
            // moscovio
            // 
            this.moscovio.AutoSize = true;
            this.moscovio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moscovio.Location = new System.Drawing.Point(115, 148);
            this.moscovio.Name = "moscovio";
            this.moscovio.Size = new System.Drawing.Size(103, 23);
            this.moscovio.TabIndex = 0;
            this.moscovio.Text = "Moscovio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(2, 187);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(353, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Mc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(352, 300);
            this.Controls.Add(this.info);
            this.Controls.Add(this.moscovio);
            this.Controls.Add(this.mos);
            this.Controls.Add(this.l115);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mc";
            this.Text = "Mc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l115;
        private System.Windows.Forms.Label mos;
        private System.Windows.Forms.Label moscovio;
        private System.Windows.Forms.Label info;
    }
}