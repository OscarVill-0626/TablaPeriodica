namespace TablaPeriodica
{
    partial class Ac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ac));
            this.l89 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.actinio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l89
            // 
            this.l89.AutoSize = true;
            this.l89.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l89.Location = new System.Drawing.Point(248, 9);
            this.l89.Name = "l89";
            this.l89.Size = new System.Drawing.Size(34, 23);
            this.l89.TabIndex = 0;
            this.l89.Text = "89";
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.Location = new System.Drawing.Point(81, -2);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(170, 116);
            this.acc.TabIndex = 0;
            this.acc.Text = "Ac";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 137);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // actinio
            // 
            this.actinio.AutoSize = true;
            this.actinio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actinio.Location = new System.Drawing.Point(136, 114);
            this.actinio.Name = "actinio";
            this.actinio.Size = new System.Drawing.Size(83, 23);
            this.actinio.TabIndex = 0;
            this.actinio.Text = "Actinio";
            // 
            // Ac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.actinio);
            this.Controls.Add(this.info);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.l89);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ac";
            this.Text = "Ac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l89;
        private System.Windows.Forms.Label acc;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label actinio;
    }
}