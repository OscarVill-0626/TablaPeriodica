namespace TablaPeriodica
{
    partial class Ga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ga));
            this.l31 = new System.Windows.Forms.Label();
            this.gal = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.galio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l31
            // 
            this.l31.AutoSize = true;
            this.l31.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l31.Location = new System.Drawing.Point(216, 9);
            this.l31.Name = "l31";
            this.l31.Size = new System.Drawing.Size(32, 23);
            this.l31.TabIndex = 0;
            this.l31.Text = "31";
            // 
            // gal
            // 
            this.gal.AutoSize = true;
            this.gal.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gal.Location = new System.Drawing.Point(71, 32);
            this.gal.Name = "gal";
            this.gal.Size = new System.Drawing.Size(177, 116);
            this.gal.TabIndex = 0;
            this.gal.Text = "Ga";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 178);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // galio
            // 
            this.galio.AutoSize = true;
            this.galio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galio.Location = new System.Drawing.Point(128, 148);
            this.galio.Name = "galio";
            this.galio.Size = new System.Drawing.Size(62, 23);
            this.galio.TabIndex = 0;
            this.galio.Text = "Galio";
            // 
            // Ga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(339, 299);
            this.Controls.Add(this.galio);
            this.Controls.Add(this.info);
            this.Controls.Add(this.gal);
            this.Controls.Add(this.l31);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ga";
            this.Text = "Ga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l31;
        private System.Windows.Forms.Label gal;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label galio;
    }
}