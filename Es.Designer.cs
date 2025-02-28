namespace TablaPeriodica
{
    partial class Es
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Es));
            this.label1 = new System.Windows.Forms.Label();
            this.ess = new System.Windows.Forms.Label();
            this.eintenio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "99";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ess
            // 
            this.ess.AutoSize = true;
            this.ess.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ess.Location = new System.Drawing.Point(80, -9);
            this.ess.Name = "ess";
            this.ess.Size = new System.Drawing.Size(159, 116);
            this.ess.TabIndex = 0;
            this.ess.Text = "Es";
            // 
            // eintenio
            // 
            this.eintenio.AutoSize = true;
            this.eintenio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eintenio.Location = new System.Drawing.Point(108, 96);
            this.eintenio.Name = "eintenio";
            this.eintenio.Size = new System.Drawing.Size(105, 23);
            this.eintenio.TabIndex = 0;
            this.eintenio.Text = "Einstenio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 119);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(324, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Es
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(325, 243);
            this.Controls.Add(this.info);
            this.Controls.Add(this.eintenio);
            this.Controls.Add(this.ess);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Es";
            this.Text = "Es";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ess;
        private System.Windows.Forms.Label eintenio;
        private System.Windows.Forms.Label info;
    }
}