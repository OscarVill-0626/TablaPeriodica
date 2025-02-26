namespace TablaPeriodica
{
    partial class Fl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fl));
            this.l114 = new System.Windows.Forms.Label();
            this.fle = new System.Windows.Forms.Label();
            this.flerovio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l114
            // 
            this.l114.AutoSize = true;
            this.l114.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l114.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l114.Location = new System.Drawing.Point(197, 9);
            this.l114.Name = "l114";
            this.l114.Size = new System.Drawing.Size(40, 23);
            this.l114.TabIndex = 0;
            this.l114.Text = "114";
            this.l114.Click += new System.EventHandler(this.l114_Click);
            // 
            // fle
            // 
            this.fle.AutoSize = true;
            this.fle.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fle.Location = new System.Drawing.Point(82, 31);
            this.fle.Name = "fle";
            this.fle.Size = new System.Drawing.Size(143, 116);
            this.fle.TabIndex = 0;
            this.fle.Text = "Fl";
            // 
            // flerovio
            // 
            this.flerovio.AutoSize = true;
            this.flerovio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flerovio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flerovio.Location = new System.Drawing.Point(115, 147);
            this.flerovio.Name = "flerovio";
            this.flerovio.Size = new System.Drawing.Size(93, 23);
            this.flerovio.TabIndex = 0;
            this.flerovio.Text = "Flerovio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-2, 197);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(336, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Fl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(333, 318);
            this.Controls.Add(this.info);
            this.Controls.Add(this.flerovio);
            this.Controls.Add(this.fle);
            this.Controls.Add(this.l114);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fl";
            this.Text = "Fl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l114;
        private System.Windows.Forms.Label fle;
        private System.Windows.Forms.Label flerovio;
        private System.Windows.Forms.Label info;
    }
}