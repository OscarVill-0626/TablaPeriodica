namespace TablaPeriodica
{
    partial class Rn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rn));
            this.l86 = new System.Windows.Forms.Label();
            this.ra = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.rad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l86
            // 
            this.l86.AutoSize = true;
            this.l86.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l86.Location = new System.Drawing.Point(239, 9);
            this.l86.Name = "l86";
            this.l86.Size = new System.Drawing.Size(34, 23);
            this.l86.TabIndex = 0;
            this.l86.Text = "86";
            this.l86.Click += new System.EventHandler(this.label1_Click);
            // 
            // ra
            // 
            this.ra.AutoSize = true;
            this.ra.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra.Location = new System.Drawing.Point(72, -8);
            this.ra.Name = "ra";
            this.ra.Size = new System.Drawing.Size(170, 116);
            this.ra.TabIndex = 0;
            this.ra.Text = "Rn";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 139);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(346, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // rad
            // 
            this.rad.AutoSize = true;
            this.rad.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad.Location = new System.Drawing.Point(119, 108);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(72, 23);
            this.rad.TabIndex = 0;
            this.rad.Text = "Radón";
            // 
            // Rn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(347, 258);
            this.Controls.Add(this.info);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.ra);
            this.Controls.Add(this.l86);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rn";
            this.Text = "Rn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l86;
        private System.Windows.Forms.Label ra;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label rad;
    }
}