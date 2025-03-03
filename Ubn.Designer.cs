namespace TablaPeriodica
{
    partial class Ubn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ubn));
            this.unbinilium = new System.Windows.Forms.Label();
            this.ubnn = new System.Windows.Forms.Label();
            this.l120 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unbinilium
            // 
            this.unbinilium.AutoSize = true;
            this.unbinilium.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unbinilium.Location = new System.Drawing.Point(77, 129);
            this.unbinilium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unbinilium.Name = "unbinilium";
            this.unbinilium.Size = new System.Drawing.Size(101, 20);
            this.unbinilium.TabIndex = 0;
            this.unbinilium.Text = "Unbinilium";
            // 
            // ubnn
            // 
            this.ubnn.AutoSize = true;
            this.ubnn.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubnn.Location = new System.Drawing.Point(11, 9);
            this.ubnn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ubnn.Name = "ubnn";
            this.ubnn.Size = new System.Drawing.Size(237, 116);
            this.ubnn.TabIndex = 1;
            this.ubnn.Text = "Ubn";
            // 
            // l120
            // 
            this.l120.AutoSize = true;
            this.l120.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l120.Location = new System.Drawing.Point(226, 9);
            this.l120.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l120.Name = "l120";
            this.l120.Size = new System.Drawing.Size(48, 20);
            this.l120.TabIndex = 2;
            this.l120.Text = "120*";
            // 
            // Ubn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(278, 163);
            this.Controls.Add(this.l120);
            this.Controls.Add(this.ubnn);
            this.Controls.Add(this.unbinilium);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ubn";
            this.Text = "Ubn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unbinilium;
        private System.Windows.Forms.Label ubnn;
        private System.Windows.Forms.Label l120;
    }
}