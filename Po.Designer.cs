namespace TablaPeriodica
{
    partial class Po
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Po));
            this.l84 = new System.Windows.Forms.Label();
            this.pol = new System.Windows.Forms.Label();
            this.polonio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l84
            // 
            this.l84.AutoSize = true;
            this.l84.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l84.Location = new System.Drawing.Point(221, 2);
            this.l84.Name = "l84";
            this.l84.Size = new System.Drawing.Size(34, 23);
            this.l84.TabIndex = 0;
            this.l84.Text = "84";
            // 
            // pol
            // 
            this.pol.AutoSize = true;
            this.pol.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol.Location = new System.Drawing.Point(96, 25);
            this.pol.Name = "pol";
            this.pol.Size = new System.Drawing.Size(170, 116);
            this.pol.TabIndex = 0;
            this.pol.Text = "Po";
            // 
            // polonio
            // 
            this.polonio.AutoSize = true;
            this.polonio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polonio.Location = new System.Drawing.Point(123, 141);
            this.polonio.Name = "polonio";
            this.polonio.Size = new System.Drawing.Size(85, 23);
            this.polonio.TabIndex = 0;
            this.polonio.Text = "Polonio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 168);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(347, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Po
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(350, 283);
            this.Controls.Add(this.info);
            this.Controls.Add(this.polonio);
            this.Controls.Add(this.pol);
            this.Controls.Add(this.l84);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Po";
            this.Text = "Po";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l84;
        private System.Windows.Forms.Label pol;
        private System.Windows.Forms.Label polonio;
        private System.Windows.Forms.Label info;
    }
}