namespace TablaPeriodica
{
    partial class Eu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eu));
            this.l63 = new System.Windows.Forms.Label();
            this.Euu = new System.Windows.Forms.Label();
            this.Europio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l63
            // 
            this.l63.AutoSize = true;
            this.l63.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l63.Location = new System.Drawing.Point(271, 9);
            this.l63.Name = "l63";
            this.l63.Size = new System.Drawing.Size(35, 23);
            this.l63.TabIndex = 0;
            this.l63.Text = "63";
            // 
            // Euu
            // 
            this.Euu.AutoSize = true;
            this.Euu.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Euu.Location = new System.Drawing.Point(95, -9);
            this.Euu.Name = "Euu";
            this.Euu.Size = new System.Drawing.Size(170, 116);
            this.Euu.TabIndex = 0;
            this.Euu.Text = "Eu";
            // 
            // Europio
            // 
            this.Europio.AutoSize = true;
            this.Europio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Europio.Location = new System.Drawing.Point(126, 107);
            this.Europio.Name = "Europio";
            this.Europio.Size = new System.Drawing.Size(87, 23);
            this.Europio.TabIndex = 0;
            this.Europio.Text = "Europio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 130);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Eu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(340, 245);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Europio);
            this.Controls.Add(this.Euu);
            this.Controls.Add(this.l63);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Eu";
            this.Text = "Eu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l63;
        private System.Windows.Forms.Label Euu;
        private System.Windows.Forms.Label Europio;
        private System.Windows.Forms.Label info;
    }
}