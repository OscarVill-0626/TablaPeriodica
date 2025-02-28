namespace TablaPeriodica
{
    partial class No
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(No));
            this.l102 = new System.Windows.Forms.Label();
            this.tii = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.nobelio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l102
            // 
            this.l102.AutoSize = true;
            this.l102.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l102.Location = new System.Drawing.Point(262, 9);
            this.l102.Name = "l102";
            this.l102.Size = new System.Drawing.Size(45, 23);
            this.l102.TabIndex = 0;
            this.l102.Text = "102";
            this.l102.Click += new System.EventHandler(this.label1_Click);
            // 
            // tii
            // 
            this.tii.AutoSize = true;
            this.tii.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tii.Location = new System.Drawing.Point(78, -1);
            this.tii.Name = "tii";
            this.tii.Size = new System.Drawing.Size(178, 116);
            this.tii.TabIndex = 0;
            this.tii.Text = "No";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 124);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // nobelio
            // 
            this.nobelio.AutoSize = true;
            this.nobelio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobelio.Location = new System.Drawing.Point(122, 101);
            this.nobelio.Name = "nobelio";
            this.nobelio.Size = new System.Drawing.Size(86, 23);
            this.nobelio.TabIndex = 0;
            this.nobelio.Text = "Nobelio";
            // 
            // No
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(329, 244);
            this.Controls.Add(this.nobelio);
            this.Controls.Add(this.tii);
            this.Controls.Add(this.info);
            this.Controls.Add(this.l102);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "No";
            this.Text = "No";
            this.Load += new System.EventHandler(this.No_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l102;
        private System.Windows.Forms.Label tii;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label nobelio;
    }
}