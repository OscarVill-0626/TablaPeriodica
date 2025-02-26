namespace TablaPeriodica
{
    partial class Sn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sn));
            this.l50 = new System.Windows.Forms.Label();
            this.snt = new System.Windows.Forms.Label();
            this.estaño = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l50
            // 
            this.l50.AutoSize = true;
            this.l50.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l50.Location = new System.Drawing.Point(267, 7);
            this.l50.Name = "l50";
            this.l50.Size = new System.Drawing.Size(34, 23);
            this.l50.TabIndex = 0;
            this.l50.Text = "50";
            // 
            // snt
            // 
            this.snt.AutoSize = true;
            this.snt.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snt.Location = new System.Drawing.Point(96, 7);
            this.snt.Name = "snt";
            this.snt.Size = new System.Drawing.Size(165, 116);
            this.snt.TabIndex = 0;
            this.snt.Text = "Sn";
            // 
            // estaño
            // 
            this.estaño.AutoSize = true;
            this.estaño.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estaño.Location = new System.Drawing.Point(130, 109);
            this.estaño.Name = "estaño";
            this.estaño.Size = new System.Drawing.Size(80, 23);
            this.estaño.TabIndex = 0;
            this.estaño.Text = "Estaño";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 142);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Sn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(334, 260);
            this.Controls.Add(this.info);
            this.Controls.Add(this.estaño);
            this.Controls.Add(this.snt);
            this.Controls.Add(this.l50);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sn";
            this.Text = "Sn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l50;
        private System.Windows.Forms.Label snt;
        private System.Windows.Forms.Label estaño;
        private System.Windows.Forms.Label info;
    }
}