namespace TablaPeriodica
{
    partial class Ni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ni));
            this.l28 = new System.Windows.Forms.Label();
            this.niq = new System.Windows.Forms.Label();
            this.niquel = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l28
            // 
            this.l28.AutoSize = true;
            this.l28.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l28.Location = new System.Drawing.Point(195, -1);
            this.l28.Name = "l28";
            this.l28.Size = new System.Drawing.Size(35, 23);
            this.l28.TabIndex = 0;
            this.l28.Text = "28";
            // 
            // niq
            // 
            this.niq.AutoSize = true;
            this.niq.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niq.Location = new System.Drawing.Point(86, 22);
            this.niq.Name = "niq";
            this.niq.Size = new System.Drawing.Size(144, 116);
            this.niq.TabIndex = 0;
            this.niq.Text = "Ni";
            // 
            // niquel
            // 
            this.niquel.AutoSize = true;
            this.niquel.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niquel.Location = new System.Drawing.Point(121, 138);
            this.niquel.Name = "niquel";
            this.niquel.Size = new System.Drawing.Size(75, 23);
            this.niquel.TabIndex = 0;
            this.niquel.Text = "Níquel";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-3, 164);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(331, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(329, 281);
            this.Controls.Add(this.info);
            this.Controls.Add(this.niquel);
            this.Controls.Add(this.niq);
            this.Controls.Add(this.l28);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ni";
            this.Text = "Ni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l28;
        private System.Windows.Forms.Label niq;
        private System.Windows.Forms.Label niquel;
        private System.Windows.Forms.Label info;
    }
}