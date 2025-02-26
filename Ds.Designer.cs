namespace TablaPeriodica
{
    partial class Ds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ds));
            this.l110 = new System.Windows.Forms.Label();
            this.dar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.darms = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l110
            // 
            this.l110.AutoSize = true;
            this.l110.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l110.Location = new System.Drawing.Point(200, 2);
            this.l110.Name = "l110";
            this.l110.Size = new System.Drawing.Size(41, 23);
            this.l110.TabIndex = 0;
            this.l110.Text = "110";
            // 
            // dar
            // 
            this.dar.AutoSize = true;
            this.dar.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dar.Location = new System.Drawing.Point(75, 25);
            this.dar.Name = "dar";
            this.dar.Size = new System.Drawing.Size(166, 116);
            this.dar.TabIndex = 0;
            this.dar.Text = "Ds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // darms
            // 
            this.darms.AutoSize = true;
            this.darms.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darms.Location = new System.Drawing.Point(93, 137);
            this.darms.Name = "darms";
            this.darms.Size = new System.Drawing.Size(123, 23);
            this.darms.TabIndex = 0;
            this.darms.Text = "Darmstatio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(8, 193);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(331, 318);
            this.Controls.Add(this.info);
            this.Controls.Add(this.darms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dar);
            this.Controls.Add(this.l110);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ds";
            this.Text = "Ds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l110;
        private System.Windows.Forms.Label dar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label darms;
        private System.Windows.Forms.Label info;
    }
}