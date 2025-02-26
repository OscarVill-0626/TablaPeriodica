namespace TablaPeriodica
{
    partial class I
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I));
            this.l53 = new System.Windows.Forms.Label();
            this.yo = new System.Windows.Forms.Label();
            this.yodo = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l53
            // 
            this.l53.AutoSize = true;
            this.l53.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l53.Location = new System.Drawing.Point(211, 3);
            this.l53.Name = "l53";
            this.l53.Size = new System.Drawing.Size(34, 23);
            this.l53.TabIndex = 0;
            this.l53.Text = "53";
            this.l53.Click += new System.EventHandler(this.l53_Click);
            // 
            // yo
            // 
            this.yo.AutoSize = true;
            this.yo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yo.Location = new System.Drawing.Point(151, 26);
            this.yo.Name = "yo";
            this.yo.Size = new System.Drawing.Size(75, 116);
            this.yo.TabIndex = 0;
            this.yo.Text = "I";
            // 
            // yodo
            // 
            this.yodo.AutoSize = true;
            this.yodo.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yodo.Location = new System.Drawing.Point(157, 131);
            this.yodo.Name = "yodo";
            this.yodo.Size = new System.Drawing.Size(58, 23);
            this.yodo.TabIndex = 0;
            this.yodo.Text = "Yodo";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(2, 165);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(341, 283);
            this.Controls.Add(this.info);
            this.Controls.Add(this.yodo);
            this.Controls.Add(this.yo);
            this.Controls.Add(this.l53);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "I";
            this.Text = "I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l53;
        private System.Windows.Forms.Label yo;
        private System.Windows.Forms.Label yodo;
        private System.Windows.Forms.Label info;
    }
}