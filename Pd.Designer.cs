namespace TablaPeriodica
{
    partial class Pd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pd));
            this.l46 = new System.Windows.Forms.Label();
            this.pal = new System.Windows.Forms.Label();
            this.paladio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l46
            // 
            this.l46.AutoSize = true;
            this.l46.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l46.Location = new System.Drawing.Point(243, 9);
            this.l46.Name = "l46";
            this.l46.Size = new System.Drawing.Size(34, 23);
            this.l46.TabIndex = 0;
            this.l46.Text = "46";
            // 
            // pal
            // 
            this.pal.AutoSize = true;
            this.pal.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pal.Location = new System.Drawing.Point(96, 37);
            this.pal.Name = "pal";
            this.pal.Size = new System.Drawing.Size(169, 116);
            this.pal.TabIndex = 0;
            this.pal.Text = "Pd";
            // 
            // paladio
            // 
            this.paladio.AutoSize = true;
            this.paladio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paladio.Location = new System.Drawing.Point(130, 153);
            this.paladio.Name = "paladio";
            this.paladio.Size = new System.Drawing.Size(84, 23);
            this.paladio.TabIndex = 0;
            this.paladio.Text = "Paladio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 176);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Pd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(344, 297);
            this.Controls.Add(this.info);
            this.Controls.Add(this.paladio);
            this.Controls.Add(this.pal);
            this.Controls.Add(this.l46);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pd";
            this.Text = "Pd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l46;
        private System.Windows.Forms.Label pal;
        private System.Windows.Forms.Label paladio;
        private System.Windows.Forms.Label info;
    }
}