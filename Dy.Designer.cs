namespace TablaPeriodica
{
    partial class Dy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dy));
            this.l66 = new System.Windows.Forms.Label();
            this.dyy = new System.Windows.Forms.Label();
            this.disprosio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l66
            // 
            this.l66.AutoSize = true;
            this.l66.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l66.Location = new System.Drawing.Point(255, 9);
            this.l66.Name = "l66";
            this.l66.Size = new System.Drawing.Size(34, 23);
            this.l66.TabIndex = 0;
            this.l66.Text = "66";
            this.l66.Click += new System.EventHandler(this.label1_Click);
            // 
            // dyy
            // 
            this.dyy.AutoSize = true;
            this.dyy.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dyy.Location = new System.Drawing.Point(73, -5);
            this.dyy.Name = "dyy";
            this.dyy.Size = new System.Drawing.Size(176, 116);
            this.dyy.TabIndex = 0;
            this.dyy.Text = "Dy";
            // 
            // disprosio
            // 
            this.disprosio.AutoSize = true;
            this.disprosio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disprosio.Location = new System.Drawing.Point(113, 111);
            this.disprosio.Name = "disprosio";
            this.disprosio.Size = new System.Drawing.Size(101, 23);
            this.disprosio.TabIndex = 0;
            this.disprosio.Text = "Disprosio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 144);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Dy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(352, 258);
            this.Controls.Add(this.info);
            this.Controls.Add(this.disprosio);
            this.Controls.Add(this.dyy);
            this.Controls.Add(this.l66);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dy";
            this.Text = "Dy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l66;
        private System.Windows.Forms.Label dyy;
        private System.Windows.Forms.Label disprosio;
        private System.Windows.Forms.Label info;
    }
}