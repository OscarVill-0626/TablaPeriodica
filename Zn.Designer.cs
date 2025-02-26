namespace TablaPeriodica
{
    partial class Zn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zn));
            this.l30 = new System.Windows.Forms.Label();
            this.zin = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.zinc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l30
            // 
            this.l30.AutoSize = true;
            this.l30.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l30.Location = new System.Drawing.Point(256, 9);
            this.l30.Name = "l30";
            this.l30.Size = new System.Drawing.Size(36, 23);
            this.l30.TabIndex = 0;
            this.l30.Text = "30";
            // 
            // zin
            // 
            this.zin.AutoSize = true;
            this.zin.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zin.Location = new System.Drawing.Point(79, -2);
            this.zin.Name = "zin";
            this.zin.Size = new System.Drawing.Size(171, 116);
            this.zin.TabIndex = 0;
            this.zin.Text = "Zn";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 116);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // zinc
            // 
            this.zinc.AutoSize = true;
            this.zinc.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zinc.Location = new System.Drawing.Point(134, 91);
            this.zinc.Name = "zinc";
            this.zinc.Size = new System.Drawing.Size(53, 23);
            this.zinc.TabIndex = 0;
            this.zinc.Text = "Zinc";
            // 
            // Zn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(334, 233);
            this.Controls.Add(this.zinc);
            this.Controls.Add(this.info);
            this.Controls.Add(this.zin);
            this.Controls.Add(this.l30);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Zn";
            this.Text = "Zn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l30;
        private System.Windows.Forms.Label zin;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label zinc;
    }
}