namespace TablaPeriodica
{
    partial class Am
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Am));
            this.l95 = new System.Windows.Forms.Label();
            this.amm = new System.Windows.Forms.Label();
            this.amiricio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l95
            // 
            this.l95.AutoSize = true;
            this.l95.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l95.Location = new System.Drawing.Point(253, 13);
            this.l95.Name = "l95";
            this.l95.Size = new System.Drawing.Size(33, 23);
            this.l95.TabIndex = 0;
            this.l95.Text = "95";
            // 
            // amm
            // 
            this.amm.AutoSize = true;
            this.amm.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amm.Location = new System.Drawing.Point(50, -10);
            this.amm.Name = "amm";
            this.amm.Size = new System.Drawing.Size(206, 116);
            this.amm.TabIndex = 0;
            this.amm.Text = "Am";
            // 
            // amiricio
            // 
            this.amiricio.AutoSize = true;
            this.amiricio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amiricio.Location = new System.Drawing.Point(119, 106);
            this.amiricio.Name = "amiricio";
            this.amiricio.Size = new System.Drawing.Size(100, 23);
            this.amiricio.TabIndex = 0;
            this.amiricio.Text = "Americio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 129);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Am
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(327, 251);
            this.Controls.Add(this.info);
            this.Controls.Add(this.amiricio);
            this.Controls.Add(this.amm);
            this.Controls.Add(this.l95);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Am";
            this.Text = "Am";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l95;
        private System.Windows.Forms.Label amm;
        private System.Windows.Forms.Label amiricio;
        private System.Windows.Forms.Label info;
    }
}