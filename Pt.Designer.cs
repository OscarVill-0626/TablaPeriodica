namespace TablaPeriodica
{
    partial class Pt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pt));
            this.l78 = new System.Windows.Forms.Label();
            this.pla = new System.Windows.Forms.Label();
            this.platino = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l78
            // 
            this.l78.AutoSize = true;
            this.l78.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l78.Location = new System.Drawing.Point(228, 0);
            this.l78.Name = "l78";
            this.l78.Size = new System.Drawing.Size(34, 23);
            this.l78.TabIndex = 0;
            this.l78.Text = "78";
            // 
            // pla
            // 
            this.pla.AutoSize = true;
            this.pla.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pla.Location = new System.Drawing.Point(96, 18);
            this.pla.Name = "pla";
            this.pla.Size = new System.Drawing.Size(155, 116);
            this.pla.TabIndex = 0;
            this.pla.Text = "Pt";
            // 
            // platino
            // 
            this.platino.AutoSize = true;
            this.platino.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platino.Location = new System.Drawing.Point(124, 122);
            this.platino.Name = "platino";
            this.platino.Size = new System.Drawing.Size(83, 23);
            this.platino.TabIndex = 0;
            this.platino.Text = "Platino";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-3, 145);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Pt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(338, 264);
            this.Controls.Add(this.info);
            this.Controls.Add(this.platino);
            this.Controls.Add(this.pla);
            this.Controls.Add(this.l78);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pt";
            this.Text = "Pt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l78;
        private System.Windows.Forms.Label pla;
        private System.Windows.Forms.Label platino;
        private System.Windows.Forms.Label info;
    }
}