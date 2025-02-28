namespace TablaPeriodica
{
    partial class U
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U));
            this.l92 = new System.Windows.Forms.Label();
            this.Uu = new System.Windows.Forms.Label();
            this.uranio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l92
            // 
            this.l92.AutoSize = true;
            this.l92.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l92.Location = new System.Drawing.Point(234, 9);
            this.l92.Name = "l92";
            this.l92.Size = new System.Drawing.Size(35, 23);
            this.l92.TabIndex = 0;
            this.l92.Text = "92";
            // 
            // Uu
            // 
            this.Uu.AutoSize = true;
            this.Uu.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uu.Location = new System.Drawing.Point(108, -7);
            this.Uu.Name = "Uu";
            this.Uu.Size = new System.Drawing.Size(120, 116);
            this.Uu.TabIndex = 0;
            this.Uu.Text = "U";
            // 
            // uranio
            // 
            this.uranio.AutoSize = true;
            this.uranio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uranio.Location = new System.Drawing.Point(137, 109);
            this.uranio.Name = "uranio";
            this.uranio.Size = new System.Drawing.Size(77, 23);
            this.uranio.TabIndex = 0;
            this.uranio.Text = "Uranio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 144);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // U
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.info);
            this.Controls.Add(this.uranio);
            this.Controls.Add(this.Uu);
            this.Controls.Add(this.l92);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "U";
            this.Text = "U";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l92;
        private System.Windows.Forms.Label Uu;
        private System.Windows.Forms.Label uranio;
        private System.Windows.Forms.Label info;
    }
}