namespace TablaPeriodica
{
    partial class Si
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Si));
            this.l14 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Label();
            this.silicio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l14
            // 
            this.l14.AutoSize = true;
            this.l14.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l14.Location = new System.Drawing.Point(227, 24);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(31, 23);
            this.l14.TabIndex = 0;
            this.l14.Text = "14";
            // 
            // sil
            // 
            this.sil.AutoSize = true;
            this.sil.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(100, 9);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(131, 116);
            this.sil.TabIndex = 0;
            this.sil.Text = "Si";
            // 
            // silicio
            // 
            this.silicio.AutoSize = true;
            this.silicio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silicio.Location = new System.Drawing.Point(116, 115);
            this.silicio.Name = "silicio";
            this.silicio.Size = new System.Drawing.Size(70, 23);
            this.silicio.TabIndex = 0;
            this.silicio.Text = "Silicio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 146);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Si
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(347, 265);
            this.Controls.Add(this.info);
            this.Controls.Add(this.silicio);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.l14);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Si";
            this.Text = "Si";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.Label sil;
        private System.Windows.Forms.Label silicio;
        private System.Windows.Forms.Label info;
    }
}