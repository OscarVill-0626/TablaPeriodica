namespace TablaPeriodica
{
    partial class Gd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gd));
            this.l64 = new System.Windows.Forms.Label();
            this.gdd = new System.Windows.Forms.Label();
            this.gadolinio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l64
            // 
            this.l64.AutoSize = true;
            this.l64.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l64.Location = new System.Drawing.Point(280, 9);
            this.l64.Name = "l64";
            this.l64.Size = new System.Drawing.Size(34, 23);
            this.l64.TabIndex = 0;
            this.l64.Text = "64";
            // 
            // gdd
            // 
            this.gdd.AutoSize = true;
            this.gdd.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdd.Location = new System.Drawing.Point(97, -9);
            this.gdd.Name = "gdd";
            this.gdd.Size = new System.Drawing.Size(177, 116);
            this.gdd.TabIndex = 0;
            this.gdd.Text = "Gd";
            // 
            // gadolinio
            // 
            this.gadolinio.AutoSize = true;
            this.gadolinio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gadolinio.Location = new System.Drawing.Point(132, 107);
            this.gadolinio.Name = "gadolinio";
            this.gadolinio.Size = new System.Drawing.Size(105, 23);
            this.gadolinio.TabIndex = 0;
            this.gadolinio.Text = "Gadolinio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-2, 130);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Gd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(339, 245);
            this.Controls.Add(this.info);
            this.Controls.Add(this.gadolinio);
            this.Controls.Add(this.gdd);
            this.Controls.Add(this.l64);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gd";
            this.Text = "Gd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l64;
        private System.Windows.Forms.Label gdd;
        private System.Windows.Forms.Label gadolinio;
        private System.Windows.Forms.Label info;
    }
}