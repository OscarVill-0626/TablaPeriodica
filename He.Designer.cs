namespace TablaPeriodica
{
    partial class He
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(He));
            this.l2 = new System.Windows.Forms.Label();
            this.hel = new System.Windows.Forms.Label();
            this.helio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(234, 8);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(23, 23);
            this.l2.TabIndex = 0;
            this.l2.Text = "2";
            // 
            // hel
            // 
            this.hel.AutoSize = true;
            this.hel.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hel.Location = new System.Drawing.Point(84, 31);
            this.hel.Name = "hel";
            this.hel.Size = new System.Drawing.Size(173, 116);
            this.hel.TabIndex = 0;
            this.hel.Text = "He";
            // 
            // helio
            // 
            this.helio.AutoSize = true;
            this.helio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helio.Location = new System.Drawing.Point(136, 147);
            this.helio.Name = "helio";
            this.helio.Size = new System.Drawing.Size(61, 23);
            this.helio.TabIndex = 0;
            this.helio.Text = "Helio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 179);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // He
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(322, 305);
            this.Controls.Add(this.info);
            this.Controls.Add(this.helio);
            this.Controls.Add(this.hel);
            this.Controls.Add(this.l2);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "He";
            this.Text = "He";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label hel;
        private System.Windows.Forms.Label helio;
        private System.Windows.Forms.Label info;
    }
}