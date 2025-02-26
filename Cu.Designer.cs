namespace TablaPeriodica
{
    partial class Cu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cu));
            this.l29 = new System.Windows.Forms.Label();
            this.cuo = new System.Windows.Forms.Label();
            this.cobre = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l29
            // 
            this.l29.AutoSize = true;
            this.l29.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l29.Location = new System.Drawing.Point(248, 9);
            this.l29.Name = "l29";
            this.l29.Size = new System.Drawing.Size(35, 23);
            this.l29.TabIndex = 0;
            this.l29.Text = "29";
            // 
            // cuo
            // 
            this.cuo.AutoSize = true;
            this.cuo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuo.Location = new System.Drawing.Point(88, 29);
            this.cuo.Name = "cuo";
            this.cuo.Size = new System.Drawing.Size(174, 116);
            this.cuo.TabIndex = 0;
            this.cuo.Text = "Cu";
            // 
            // cobre
            // 
            this.cobre.AutoSize = true;
            this.cobre.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobre.Location = new System.Drawing.Point(150, 154);
            this.cobre.Name = "cobre";
            this.cobre.Size = new System.Drawing.Size(69, 23);
            this.cobre.TabIndex = 0;
            this.cobre.Text = "Cobre";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(2, 191);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Cu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(345, 318);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cobre);
            this.Controls.Add(this.cuo);
            this.Controls.Add(this.l29);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cu";
            this.Text = "Cu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l29;
        private System.Windows.Forms.Label cuo;
        private System.Windows.Forms.Label cobre;
        private System.Windows.Forms.Label info;
    }
}