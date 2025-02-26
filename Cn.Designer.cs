namespace TablaPeriodica
{
    partial class Cn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cn));
            this.l112 = new System.Windows.Forms.Label();
            this.cop = new System.Windows.Forms.Label();
            this.copernico = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l112
            // 
            this.l112.AutoSize = true;
            this.l112.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l112.Location = new System.Drawing.Point(211, 13);
            this.l112.Name = "l112";
            this.l112.Size = new System.Drawing.Size(41, 23);
            this.l112.TabIndex = 0;
            this.l112.Text = "112";
            // 
            // cop
            // 
            this.cop.AutoSize = true;
            this.cop.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cop.Location = new System.Drawing.Point(78, 36);
            this.cop.Name = "cop";
            this.cop.Size = new System.Drawing.Size(174, 116);
            this.cop.TabIndex = 0;
            this.cop.Text = "Cn";
            // 
            // copernico
            // 
            this.copernico.AutoSize = true;
            this.copernico.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copernico.Location = new System.Drawing.Point(113, 152);
            this.copernico.Name = "copernico";
            this.copernico.Size = new System.Drawing.Size(112, 23);
            this.copernico.TabIndex = 0;
            this.copernico.Text = "Copérnico";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 212);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(327, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Cn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(342, 332);
            this.Controls.Add(this.info);
            this.Controls.Add(this.copernico);
            this.Controls.Add(this.cop);
            this.Controls.Add(this.l112);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cn";
            this.Text = "Cn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l112;
        private System.Windows.Forms.Label cop;
        private System.Windows.Forms.Label copernico;
        private System.Windows.Forms.Label info;
    }
}