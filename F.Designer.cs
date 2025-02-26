namespace TablaPeriodica
{
    partial class F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F));
            this.l9 = new System.Windows.Forms.Label();
            this.dlu = new System.Windows.Forms.Label();
            this.fluor = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(190, 6);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(22, 23);
            this.l9.TabIndex = 0;
            this.l9.Text = "9";
            // 
            // dlu
            // 
            this.dlu.AutoSize = true;
            this.dlu.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlu.Location = new System.Drawing.Point(101, 25);
            this.dlu.Name = "dlu";
            this.dlu.Size = new System.Drawing.Size(111, 116);
            this.dlu.TabIndex = 1;
            this.dlu.Text = "F";
            // 
            // fluor
            // 
            this.fluor.AutoSize = true;
            this.fluor.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluor.Location = new System.Drawing.Point(104, 141);
            this.fluor.Name = "fluor";
            this.fluor.Size = new System.Drawing.Size(65, 23);
            this.fluor.TabIndex = 2;
            this.fluor.Text = "Flúor";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 183);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 3;
            this.info.Text = resources.GetString("info.Text");
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(321, 299);
            this.Controls.Add(this.info);
            this.Controls.Add(this.fluor);
            this.Controls.Add(this.dlu);
            this.Controls.Add(this.l9);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F";
            this.Text = "F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label dlu;
        private System.Windows.Forms.Label fluor;
        private System.Windows.Forms.Label info;
    }
}