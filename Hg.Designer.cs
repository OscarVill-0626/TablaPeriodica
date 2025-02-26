namespace TablaPeriodica
{
    partial class Hg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hg));
            this.l80 = new System.Windows.Forms.Label();
            this.mer = new System.Windows.Forms.Label();
            this.mercurio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l80
            // 
            this.l80.AutoSize = true;
            this.l80.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l80.Location = new System.Drawing.Point(184, 9);
            this.l80.Name = "l80";
            this.l80.Size = new System.Drawing.Size(35, 23);
            this.l80.TabIndex = 0;
            this.l80.Text = "80";
            // 
            // mer
            // 
            this.mer.AutoSize = true;
            this.mer.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mer.Location = new System.Drawing.Point(62, 32);
            this.mer.Name = "mer";
            this.mer.Size = new System.Drawing.Size(174, 116);
            this.mer.TabIndex = 1;
            this.mer.Text = "Hg";
            // 
            // mercurio
            // 
            this.mercurio.AutoSize = true;
            this.mercurio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercurio.Location = new System.Drawing.Point(89, 161);
            this.mercurio.Name = "mercurio";
            this.mercurio.Size = new System.Drawing.Size(101, 23);
            this.mercurio.TabIndex = 2;
            this.mercurio.Text = "Mercurio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(2, 203);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(348, 112);
            this.info.TabIndex = 3;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Hg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(348, 323);
            this.Controls.Add(this.info);
            this.Controls.Add(this.mercurio);
            this.Controls.Add(this.mer);
            this.Controls.Add(this.l80);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hg";
            this.Text = "Hg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l80;
        private System.Windows.Forms.Label mer;
        private System.Windows.Forms.Label mercurio;
        private System.Windows.Forms.Label info;
    }
}