namespace TablaPeriodica
{
    partial class Tb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tb));
            this.l65 = new System.Windows.Forms.Label();
            this.tbb = new System.Windows.Forms.Label();
            this.terbio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l65
            // 
            this.l65.AutoSize = true;
            this.l65.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l65.Location = new System.Drawing.Point(278, 0);
            this.l65.Name = "l65";
            this.l65.Size = new System.Drawing.Size(33, 23);
            this.l65.TabIndex = 0;
            this.l65.Text = "65";
            // 
            // tbb
            // 
            this.tbb.AutoSize = true;
            this.tbb.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbb.Location = new System.Drawing.Point(94, 0);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(178, 116);
            this.tbb.TabIndex = 0;
            this.tbb.Text = "Tb";
            // 
            // terbio
            // 
            this.terbio.AutoSize = true;
            this.terbio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terbio.Location = new System.Drawing.Point(139, 103);
            this.terbio.Name = "terbio";
            this.terbio.Size = new System.Drawing.Size(75, 23);
            this.terbio.TabIndex = 0;
            this.terbio.Text = "Terbio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 126);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Tb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(355, 240);
            this.Controls.Add(this.info);
            this.Controls.Add(this.terbio);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.l65);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tb";
            this.Text = "Tb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l65;
        private System.Windows.Forms.Label tbb;
        private System.Windows.Forms.Label terbio;
        private System.Windows.Forms.Label info;
    }
}