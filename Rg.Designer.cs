namespace TablaPeriodica
{
    partial class Rg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rg));
            this.l111 = new System.Windows.Forms.Label();
            this.roe = new System.Windows.Forms.Label();
            this.roen = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l111
            // 
            this.l111.AutoSize = true;
            this.l111.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l111.Location = new System.Drawing.Point(264, 9);
            this.l111.Name = "l111";
            this.l111.Size = new System.Drawing.Size(37, 23);
            this.l111.TabIndex = 0;
            this.l111.Text = "111";
            // 
            // roe
            // 
            this.roe.AutoSize = true;
            this.roe.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roe.Location = new System.Drawing.Point(102, 9);
            this.roe.Name = "roe";
            this.roe.Size = new System.Drawing.Size(166, 116);
            this.roe.TabIndex = 0;
            this.roe.Text = "Rg";
            // 
            // roen
            // 
            this.roen.AutoSize = true;
            this.roen.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roen.Location = new System.Drawing.Point(118, 125);
            this.roen.Name = "roen";
            this.roen.Size = new System.Drawing.Size(125, 23);
            this.roen.TabIndex = 0;
            this.roen.Text = "Roentgenio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 162);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Rg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(323, 280);
            this.Controls.Add(this.info);
            this.Controls.Add(this.roen);
            this.Controls.Add(this.roe);
            this.Controls.Add(this.l111);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rg";
            this.Text = "Rg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l111;
        private System.Windows.Forms.Label roe;
        private System.Windows.Forms.Label roen;
        private System.Windows.Forms.Label info;
    }
}