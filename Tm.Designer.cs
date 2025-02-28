namespace TablaPeriodica
{
    partial class Tm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tm));
            this.l69 = new System.Windows.Forms.Label();
            this.tll = new System.Windows.Forms.Label();
            this.tulio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l69
            // 
            this.l69.AutoSize = true;
            this.l69.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l69.Location = new System.Drawing.Point(250, 9);
            this.l69.Name = "l69";
            this.l69.Size = new System.Drawing.Size(34, 23);
            this.l69.TabIndex = 0;
            this.l69.Text = "69";
            // 
            // tll
            // 
            this.tll.AutoSize = true;
            this.tll.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tll.Location = new System.Drawing.Point(92, -17);
            this.tll.Name = "tll";
            this.tll.Size = new System.Drawing.Size(152, 116);
            this.tll.TabIndex = 0;
            this.tll.Text = "Tl";
            // 
            // tulio
            // 
            this.tulio.AutoSize = true;
            this.tulio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulio.Location = new System.Drawing.Point(138, 99);
            this.tulio.Name = "tulio";
            this.tulio.Size = new System.Drawing.Size(61, 23);
            this.tulio.TabIndex = 0;
            this.tulio.Text = "Tulio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 122);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Tm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(344, 235);
            this.Controls.Add(this.info);
            this.Controls.Add(this.tulio);
            this.Controls.Add(this.tll);
            this.Controls.Add(this.l69);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tm";
            this.Text = "Tm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l69;
        private System.Windows.Forms.Label tll;
        private System.Windows.Forms.Label tulio;
        private System.Windows.Forms.Label info;
    }
}