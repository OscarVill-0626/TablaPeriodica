namespace TablaPeriodica
{
    partial class Pb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pb));
            this.l82 = new System.Windows.Forms.Label();
            this.plo = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.plomo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l82
            // 
            this.l82.AutoSize = true;
            this.l82.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l82.Location = new System.Drawing.Point(230, 9);
            this.l82.Name = "l82";
            this.l82.Size = new System.Drawing.Size(35, 23);
            this.l82.TabIndex = 0;
            this.l82.Text = "82";
            // 
            // plo
            // 
            this.plo.AutoSize = true;
            this.plo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plo.Location = new System.Drawing.Point(107, 32);
            this.plo.Name = "plo";
            this.plo.Size = new System.Drawing.Size(169, 116);
            this.plo.TabIndex = 0;
            this.plo.Text = "Pb";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 164);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(347, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // plomo
            // 
            this.plomo.AutoSize = true;
            this.plomo.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plomo.Location = new System.Drawing.Point(136, 141);
            this.plomo.Name = "plomo";
            this.plomo.Size = new System.Drawing.Size(71, 23);
            this.plomo.TabIndex = 0;
            this.plomo.Text = "Plomo";
            // 
            // Pb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(346, 288);
            this.Controls.Add(this.info);
            this.Controls.Add(this.plomo);
            this.Controls.Add(this.plo);
            this.Controls.Add(this.l82);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pb";
            this.Text = "Pb";
            this.Load += new System.EventHandler(this.Pb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l82;
        private System.Windows.Forms.Label plo;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label plomo;
    }
}