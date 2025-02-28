namespace TablaPeriodica
{
    partial class Np
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Np));
            this.l93 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.npp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l93
            // 
            this.l93.AutoSize = true;
            this.l93.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l93.Location = new System.Drawing.Point(257, 9);
            this.l93.Name = "l93";
            this.l93.Size = new System.Drawing.Size(35, 23);
            this.l93.TabIndex = 0;
            this.l93.Text = "93";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Neptunio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 128);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // npp
            // 
            this.npp.AutoSize = true;
            this.npp.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npp.Location = new System.Drawing.Point(75, -11);
            this.npp.Name = "npp";
            this.npp.Size = new System.Drawing.Size(176, 116);
            this.npp.TabIndex = 0;
            this.npp.Text = "Np";
            this.npp.Click += new System.EventHandler(this.label2_Click);
            // 
            // Np
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(344, 244);
            this.Controls.Add(this.info);
            this.Controls.Add(this.npp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l93);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Np";
            this.Text = "Np";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l93;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label npp;
    }
}