namespace TablaPeriodica
{
    partial class Kr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kr));
            this.l36 = new System.Windows.Forms.Label();
            this.cri = new System.Windows.Forms.Label();
            this.crit = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l36
            // 
            this.l36.AutoSize = true;
            this.l36.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l36.Location = new System.Drawing.Point(219, 4);
            this.l36.Name = "l36";
            this.l36.Size = new System.Drawing.Size(35, 23);
            this.l36.TabIndex = 0;
            this.l36.Text = "36";
            // 
            // cri
            // 
            this.cri.AutoSize = true;
            this.cri.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cri.Location = new System.Drawing.Point(97, 27);
            this.cri.Name = "cri";
            this.cri.Size = new System.Drawing.Size(154, 116);
            this.cri.TabIndex = 0;
            this.cri.Text = "Kr";
            // 
            // crit
            // 
            this.crit.AutoSize = true;
            this.crit.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crit.Location = new System.Drawing.Point(122, 143);
            this.crit.Name = "crit";
            this.crit.Size = new System.Drawing.Size(87, 23);
            this.crit.TabIndex = 0;
            this.crit.Text = "Criptón";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(3, 188);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Kr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(330, 303);
            this.Controls.Add(this.info);
            this.Controls.Add(this.crit);
            this.Controls.Add(this.cri);
            this.Controls.Add(this.l36);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kr";
            this.Text = "Kr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l36;
        private System.Windows.Forms.Label cri;
        private System.Windows.Forms.Label crit;
        private System.Windows.Forms.Label info;
    }
}