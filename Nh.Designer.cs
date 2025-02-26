namespace TablaPeriodica
{
    partial class Nh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nh));
            this.l113 = new System.Windows.Forms.Label();
            this.nhh = new System.Windows.Forms.Label();
            this.nihonio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l113
            // 
            this.l113.AutoSize = true;
            this.l113.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l113.Location = new System.Drawing.Point(241, 0);
            this.l113.Name = "l113";
            this.l113.Size = new System.Drawing.Size(41, 23);
            this.l113.TabIndex = 0;
            this.l113.Text = "113";
            // 
            // nhh
            // 
            this.nhh.AutoSize = true;
            this.nhh.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhh.Location = new System.Drawing.Point(104, 23);
            this.nhh.Name = "nhh";
            this.nhh.Size = new System.Drawing.Size(178, 116);
            this.nhh.TabIndex = 0;
            this.nhh.Text = "Nh";
            // 
            // nihonio
            // 
            this.nihonio.AutoSize = true;
            this.nihonio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nihonio.Location = new System.Drawing.Point(140, 136);
            this.nihonio.Name = "nihonio";
            this.nihonio.Size = new System.Drawing.Size(86, 23);
            this.nihonio.TabIndex = 0;
            this.nihonio.Text = "Nihonio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 159);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(350, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Nh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(350, 272);
            this.Controls.Add(this.info);
            this.Controls.Add(this.nihonio);
            this.Controls.Add(this.nhh);
            this.Controls.Add(this.l113);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nh";
            this.Text = "Nh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l113;
        private System.Windows.Forms.Label nhh;
        private System.Windows.Forms.Label nihonio;
        private System.Windows.Forms.Label info;
    }
}