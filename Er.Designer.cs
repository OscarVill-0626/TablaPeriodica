namespace TablaPeriodica
{
    partial class Er
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Er));
            this.l68 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.erbio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l68
            // 
            this.l68.AutoSize = true;
            this.l68.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l68.Location = new System.Drawing.Point(270, 9);
            this.l68.Name = "l68";
            this.l68.Size = new System.Drawing.Size(34, 23);
            this.l68.TabIndex = 0;
            this.l68.Text = "68";
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.Location = new System.Drawing.Point(108, -7);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(156, 116);
            this.err.TabIndex = 0;
            this.err.Text = "Er";
            this.err.Click += new System.EventHandler(this.label2_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 132);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // erbio
            // 
            this.erbio.AutoSize = true;
            this.erbio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erbio.Location = new System.Drawing.Point(139, 109);
            this.erbio.Name = "erbio";
            this.erbio.Size = new System.Drawing.Size(63, 23);
            this.erbio.TabIndex = 0;
            this.erbio.Text = "Erbio";
            this.erbio.Click += new System.EventHandler(this.label2_Click);
            // 
            // Er
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(342, 248);
            this.Controls.Add(this.info);
            this.Controls.Add(this.erbio);
            this.Controls.Add(this.err);
            this.Controls.Add(this.l68);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Er";
            this.Text = "Er";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l68;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label erbio;
    }
}