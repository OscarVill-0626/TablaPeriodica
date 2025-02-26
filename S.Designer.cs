namespace TablaPeriodica
{
    partial class S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S));
            this.l16 = new System.Windows.Forms.Label();
            this.asu = new System.Windows.Forms.Label();
            this.azu = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l16
            // 
            this.l16.AutoSize = true;
            this.l16.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l16.Location = new System.Drawing.Point(234, 9);
            this.l16.Name = "l16";
            this.l16.Size = new System.Drawing.Size(31, 23);
            this.l16.TabIndex = 0;
            this.l16.Text = "16";
            // 
            // asu
            // 
            this.asu.AutoSize = true;
            this.asu.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asu.Location = new System.Drawing.Point(133, 9);
            this.asu.Name = "asu";
            this.asu.Size = new System.Drawing.Size(106, 116);
            this.asu.TabIndex = 0;
            this.asu.Text = "S";
            // 
            // azu
            // 
            this.azu.AutoSize = true;
            this.azu.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azu.Location = new System.Drawing.Point(140, 111);
            this.azu.Name = "azu";
            this.azu.Size = new System.Drawing.Size(82, 23);
            this.azu.TabIndex = 0;
            this.azu.Text = "Azufre";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 134);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(346, 254);
            this.Controls.Add(this.info);
            this.Controls.Add(this.azu);
            this.Controls.Add(this.asu);
            this.Controls.Add(this.l16);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "S";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l16;
        private System.Windows.Forms.Label asu;
        private System.Windows.Forms.Label azu;
        private System.Windows.Forms.Label info;
    }
}