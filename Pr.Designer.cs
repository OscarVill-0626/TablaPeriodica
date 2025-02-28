namespace TablaPeriodica
{
    partial class Pr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pr));
            this.praseodimio = new System.Windows.Forms.Label();
            this.prr = new System.Windows.Forms.Label();
            this.l59 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // praseodimio
            // 
            this.praseodimio.AutoSize = true;
            this.praseodimio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.praseodimio.Location = new System.Drawing.Point(102, 108);
            this.praseodimio.Name = "praseodimio";
            this.praseodimio.Size = new System.Drawing.Size(131, 23);
            this.praseodimio.TabIndex = 0;
            this.praseodimio.Text = "Praseodimio";
            // 
            // prr
            // 
            this.prr.AutoSize = true;
            this.prr.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prr.Location = new System.Drawing.Point(86, -8);
            this.prr.Name = "prr";
            this.prr.Size = new System.Drawing.Size(156, 116);
            this.prr.TabIndex = 1;
            this.prr.Text = "Pr";
            // 
            // l59
            // 
            this.l59.AutoSize = true;
            this.l59.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l59.Location = new System.Drawing.Point(248, 9);
            this.l59.Name = "l59";
            this.l59.Size = new System.Drawing.Size(33, 23);
            this.l59.TabIndex = 2;
            this.l59.Text = "59";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 131);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 3;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Pr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(336, 251);
            this.Controls.Add(this.info);
            this.Controls.Add(this.l59);
            this.Controls.Add(this.prr);
            this.Controls.Add(this.praseodimio);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pr";
            this.Text = "Pr";
            this.Load += new System.EventHandler(this.Pr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label praseodimio;
        private System.Windows.Forms.Label prr;
        private System.Windows.Forms.Label l59;
        private System.Windows.Forms.Label info;
    }
}