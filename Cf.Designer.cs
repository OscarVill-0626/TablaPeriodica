namespace TablaPeriodica
{
    partial class Cf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cf));
            this.l98 = new System.Windows.Forms.Label();
            this.cff = new System.Windows.Forms.Label();
            this.californio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l98
            // 
            this.l98.AutoSize = true;
            this.l98.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l98.Location = new System.Drawing.Point(257, 9);
            this.l98.Name = "l98";
            this.l98.Size = new System.Drawing.Size(34, 23);
            this.l98.TabIndex = 0;
            this.l98.Text = "98";
            // 
            // cff
            // 
            this.cff.AutoSize = true;
            this.cff.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cff.Location = new System.Drawing.Point(94, -8);
            this.cff.Name = "cff";
            this.cff.Size = new System.Drawing.Size(157, 116);
            this.cff.TabIndex = 0;
            this.cff.Text = "Cf";
            // 
            // californio
            // 
            this.californio.AutoSize = true;
            this.californio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.californio.Location = new System.Drawing.Point(133, 92);
            this.californio.Name = "californio";
            this.californio.Size = new System.Drawing.Size(112, 23);
            this.californio.TabIndex = 0;
            this.californio.Text = "Californio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 115);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Cf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(324, 234);
            this.Controls.Add(this.info);
            this.Controls.Add(this.californio);
            this.Controls.Add(this.cff);
            this.Controls.Add(this.l98);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cf";
            this.Text = "Cf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l98;
        private System.Windows.Forms.Label cff;
        private System.Windows.Forms.Label californio;
        private System.Windows.Forms.Label info;
    }
}