namespace TablaPeriodica
{
    partial class Fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm));
            this.l100 = new System.Windows.Forms.Label();
            this.fmm = new System.Windows.Forms.Label();
            this.femio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l100
            // 
            this.l100.AutoSize = true;
            this.l100.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l100.Location = new System.Drawing.Point(255, 9);
            this.l100.Name = "l100";
            this.l100.Size = new System.Drawing.Size(45, 23);
            this.l100.TabIndex = 0;
            this.l100.Text = "100";
            // 
            // fmm
            // 
            this.fmm.AutoSize = true;
            this.fmm.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmm.Location = new System.Drawing.Point(75, 0);
            this.fmm.Name = "fmm";
            this.fmm.Size = new System.Drawing.Size(188, 116);
            this.fmm.TabIndex = 0;
            this.fmm.Text = "Fm";
            // 
            // femio
            // 
            this.femio.AutoSize = true;
            this.femio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femio.Location = new System.Drawing.Point(130, 116);
            this.femio.Name = "femio";
            this.femio.Size = new System.Drawing.Size(68, 23);
            this.femio.TabIndex = 0;
            this.femio.Text = "Femio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 139);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(329, 254);
            this.Controls.Add(this.info);
            this.Controls.Add(this.femio);
            this.Controls.Add(this.fmm);
            this.Controls.Add(this.l100);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fm";
            this.Text = "Fm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l100;
        private System.Windows.Forms.Label fmm;
        private System.Windows.Forms.Label femio;
        private System.Windows.Forms.Label info;
    }
}