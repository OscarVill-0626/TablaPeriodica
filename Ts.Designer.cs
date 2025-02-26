namespace TablaPeriodica
{
    partial class Ts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ts));
            this.l117 = new System.Windows.Forms.Label();
            this.te = new System.Windows.Forms.Label();
            this.teneso = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l117
            // 
            this.l117.AutoSize = true;
            this.l117.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l117.Location = new System.Drawing.Point(256, 15);
            this.l117.Name = "l117";
            this.l117.Size = new System.Drawing.Size(40, 23);
            this.l117.TabIndex = 0;
            this.l117.Text = "117";
            // 
            // te
            // 
            this.te.AutoSize = true;
            this.te.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te.Location = new System.Drawing.Point(98, 15);
            this.te.Name = "te";
            this.te.Size = new System.Drawing.Size(156, 116);
            this.te.TabIndex = 0;
            this.te.Text = "Ts";
            // 
            // teneso
            // 
            this.teneso.AutoSize = true;
            this.teneso.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teneso.Location = new System.Drawing.Point(134, 108);
            this.teneso.Name = "teneso";
            this.teneso.Size = new System.Drawing.Size(82, 23);
            this.teneso.TabIndex = 0;
            this.teneso.Text = "Teneso";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(12, 140);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(352, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(362, 263);
            this.Controls.Add(this.info);
            this.Controls.Add(this.teneso);
            this.Controls.Add(this.te);
            this.Controls.Add(this.l117);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ts";
            this.Text = "Ts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l117;
        private System.Windows.Forms.Label te;
        private System.Windows.Forms.Label teneso;
        private System.Windows.Forms.Label info;
    }
}