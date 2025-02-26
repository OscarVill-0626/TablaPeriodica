namespace TablaPeriodica
{
    partial class Ge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ge));
            this.l32 = new System.Windows.Forms.Label();
            this.ger = new System.Windows.Forms.Label();
            this.geerma = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l32
            // 
            this.l32.AutoSize = true;
            this.l32.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l32.Location = new System.Drawing.Point(237, 9);
            this.l32.Name = "l32";
            this.l32.Size = new System.Drawing.Size(36, 23);
            this.l32.TabIndex = 0;
            this.l32.Text = "32";
            // 
            // ger
            // 
            this.ger.AutoSize = true;
            this.ger.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ger.Location = new System.Drawing.Point(98, 31);
            this.ger.Name = "ger";
            this.ger.Size = new System.Drawing.Size(175, 116);
            this.ger.TabIndex = 0;
            this.ger.Text = "Ge";
            // 
            // geerma
            // 
            this.geerma.AutoSize = true;
            this.geerma.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geerma.Location = new System.Drawing.Point(133, 147);
            this.geerma.Name = "geerma";
            this.geerma.Size = new System.Drawing.Size(107, 23);
            this.geerma.TabIndex = 0;
            this.geerma.Text = "Germanio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(7, 216);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(350, 346);
            this.Controls.Add(this.info);
            this.Controls.Add(this.geerma);
            this.Controls.Add(this.ger);
            this.Controls.Add(this.l32);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ge";
            this.Text = "Ge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l32;
        private System.Windows.Forms.Label ger;
        private System.Windows.Forms.Label geerma;
        private System.Windows.Forms.Label info;
    }
}