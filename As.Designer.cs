namespace TablaPeriodica
{
    partial class As
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(As));
            this.l33 = new System.Windows.Forms.Label();
            this.ars = new System.Windows.Forms.Label();
            this.arse = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l33
            // 
            this.l33.AutoSize = true;
            this.l33.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l33.Location = new System.Drawing.Point(206, 29);
            this.l33.Name = "l33";
            this.l33.Size = new System.Drawing.Size(36, 23);
            this.l33.TabIndex = 0;
            this.l33.Text = "33";
            // 
            // ars
            // 
            this.ars.AutoSize = true;
            this.ars.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ars.Location = new System.Drawing.Point(107, 52);
            this.ars.Name = "ars";
            this.ars.Size = new System.Drawing.Size(170, 116);
            this.ars.TabIndex = 1;
            this.ars.Text = "As";
            // 
            // arse
            // 
            this.arse.AutoSize = true;
            this.arse.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arse.Location = new System.Drawing.Point(140, 168);
            this.arse.Name = "arse";
            this.arse.Size = new System.Drawing.Size(89, 23);
            this.arse.TabIndex = 2;
            this.arse.Text = "Arsénio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(8, 192);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 2;
            this.info.Text = resources.GetString("info.Text");
            // 
            // As
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.info);
            this.Controls.Add(this.arse);
            this.Controls.Add(this.ars);
            this.Controls.Add(this.l33);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "As";
            this.Text = "As";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l33;
        private System.Windows.Forms.Label ars;
        private System.Windows.Forms.Label arse;
        private System.Windows.Forms.Label info;
    }
}