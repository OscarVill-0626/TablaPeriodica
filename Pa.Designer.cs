namespace TablaPeriodica
{
    partial class Pa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pa));
            this.l91 = new System.Windows.Forms.Label();
            this.paa = new System.Windows.Forms.Label();
            this.protactinio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l91
            // 
            this.l91.AutoSize = true;
            this.l91.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l91.Location = new System.Drawing.Point(273, 9);
            this.l91.Name = "l91";
            this.l91.Size = new System.Drawing.Size(31, 23);
            this.l91.TabIndex = 0;
            this.l91.Text = "91";
            // 
            // paa
            // 
            this.paa.AutoSize = true;
            this.paa.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paa.Location = new System.Drawing.Point(98, 0);
            this.paa.Name = "paa";
            this.paa.Size = new System.Drawing.Size(169, 116);
            this.paa.TabIndex = 0;
            this.paa.Text = "Pa";
            // 
            // protactinio
            // 
            this.protactinio.AutoSize = true;
            this.protactinio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protactinio.Location = new System.Drawing.Point(114, 93);
            this.protactinio.Name = "protactinio";
            this.protactinio.Size = new System.Drawing.Size(124, 23);
            this.protactinio.TabIndex = 0;
            this.protactinio.Text = "Protactinio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(-1, 116);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Pa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(344, 234);
            this.Controls.Add(this.info);
            this.Controls.Add(this.protactinio);
            this.Controls.Add(this.paa);
            this.Controls.Add(this.l91);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pa";
            this.Text = "Pa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l91;
        private System.Windows.Forms.Label paa;
        private System.Windows.Forms.Label protactinio;
        private System.Windows.Forms.Label info;
    }
}