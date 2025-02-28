namespace TablaPeriodica
{
    partial class Nd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nd));
            this.neodimio = new System.Windows.Forms.Label();
            this.ndd = new System.Windows.Forms.Label();
            this.l60 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // neodimio
            // 
            this.neodimio.AutoSize = true;
            this.neodimio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neodimio.Location = new System.Drawing.Point(143, 125);
            this.neodimio.Name = "neodimio";
            this.neodimio.Size = new System.Drawing.Size(102, 23);
            this.neodimio.TabIndex = 0;
            this.neodimio.Text = "Neodimio";
            // 
            // ndd
            // 
            this.ndd.AutoSize = true;
            this.ndd.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndd.Location = new System.Drawing.Point(99, 9);
            this.ndd.Name = "ndd";
            this.ndd.Size = new System.Drawing.Size(177, 116);
            this.ndd.TabIndex = 1;
            this.ndd.Text = "Nd";
            // 
            // l60
            // 
            this.l60.AutoSize = true;
            this.l60.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l60.Location = new System.Drawing.Point(272, 30);
            this.l60.Name = "l60";
            this.l60.Size = new System.Drawing.Size(35, 23);
            this.l60.TabIndex = 2;
            this.l60.Text = "60";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-3, 148);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 3;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Nd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(367, 267);
            this.Controls.Add(this.info);
            this.Controls.Add(this.l60);
            this.Controls.Add(this.ndd);
            this.Controls.Add(this.neodimio);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nd";
            this.Text = "Nd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label neodimio;
        private System.Windows.Forms.Label ndd;
        private System.Windows.Forms.Label l60;
        private System.Windows.Forms.Label info;
    }
}