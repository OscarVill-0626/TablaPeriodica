namespace TablaPeriodica
{
    partial class Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xe));
            this.l54 = new System.Windows.Forms.Label();
            this.xeo = new System.Windows.Forms.Label();
            this.xenon = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l54
            // 
            this.l54.AutoSize = true;
            this.l54.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l54.Location = new System.Drawing.Point(264, 9);
            this.l54.Name = "l54";
            this.l54.Size = new System.Drawing.Size(33, 23);
            this.l54.TabIndex = 0;
            this.l54.Text = "54";
            // 
            // xeo
            // 
            this.xeo.AutoSize = true;
            this.xeo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xeo.Location = new System.Drawing.Point(93, -3);
            this.xeo.Name = "xeo";
            this.xeo.Size = new System.Drawing.Size(175, 116);
            this.xeo.TabIndex = 0;
            this.xeo.Text = "Xe";
            // 
            // xenon
            // 
            this.xenon.AutoSize = true;
            this.xenon.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xenon.Location = new System.Drawing.Point(133, 101);
            this.xenon.Name = "xenon";
            this.xenon.Size = new System.Drawing.Size(75, 23);
            this.xenon.TabIndex = 0;
            this.xenon.Text = "Xenón";
            this.xenon.Click += new System.EventHandler(this.label3_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(2, 125);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(324, 242);
            this.Controls.Add(this.info);
            this.Controls.Add(this.xenon);
            this.Controls.Add(this.xeo);
            this.Controls.Add(this.l54);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Xe";
            this.Text = "Xe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l54;
        private System.Windows.Forms.Label xeo;
        private System.Windows.Forms.Label xenon;
        private System.Windows.Forms.Label info;
    }
}