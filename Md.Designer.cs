namespace TablaPeriodica
{
    partial class Md
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Md));
            this.l101 = new System.Windows.Forms.Label();
            this.mdd = new System.Windows.Forms.Label();
            this.mendelevio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l101
            // 
            this.l101.AutoSize = true;
            this.l101.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l101.Location = new System.Drawing.Point(270, 9);
            this.l101.Name = "l101";
            this.l101.Size = new System.Drawing.Size(41, 23);
            this.l101.TabIndex = 0;
            this.l101.Text = "101";
            // 
            // mdd
            // 
            this.mdd.AutoSize = true;
            this.mdd.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdd.Location = new System.Drawing.Point(72, 1);
            this.mdd.Name = "mdd";
            this.mdd.Size = new System.Drawing.Size(192, 116);
            this.mdd.TabIndex = 0;
            this.mdd.Text = "Md";
            // 
            // mendelevio
            // 
            this.mendelevio.AutoSize = true;
            this.mendelevio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mendelevio.Location = new System.Drawing.Point(109, 106);
            this.mendelevio.Name = "mendelevio";
            this.mendelevio.Size = new System.Drawing.Size(126, 23);
            this.mendelevio.TabIndex = 0;
            this.mendelevio.Text = "Mendelevio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(6, 129);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Md
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(329, 245);
            this.Controls.Add(this.info);
            this.Controls.Add(this.mendelevio);
            this.Controls.Add(this.mdd);
            this.Controls.Add(this.l101);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Md";
            this.Text = "Md";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l101;
        private System.Windows.Forms.Label mdd;
        private System.Windows.Forms.Label mendelevio;
        private System.Windows.Forms.Label info;
    }
}