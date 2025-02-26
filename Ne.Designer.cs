namespace TablaPeriodica
{
    partial class Ne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ne));
            this.l10 = new System.Windows.Forms.Label();
            this.neo = new System.Windows.Forms.Label();
            this.neon = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10.Location = new System.Drawing.Point(235, 7);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(32, 23);
            this.l10.TabIndex = 0;
            this.l10.Text = "10";
            // 
            // neo
            // 
            this.neo.AutoSize = true;
            this.neo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neo.Location = new System.Drawing.Point(92, 30);
            this.neo.Name = "neo";
            this.neo.Size = new System.Drawing.Size(175, 116);
            this.neo.TabIndex = 0;
            this.neo.Text = "Ne";
            // 
            // neon
            // 
            this.neon.AutoSize = true;
            this.neon.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neon.Location = new System.Drawing.Point(137, 146);
            this.neon.Name = "neon";
            this.neon.Size = new System.Drawing.Size(62, 23);
            this.neon.TabIndex = 0;
            this.neon.Text = "Neón";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 213);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(329, 330);
            this.Controls.Add(this.info);
            this.Controls.Add(this.neon);
            this.Controls.Add(this.neo);
            this.Controls.Add(this.l10);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ne";
            this.Text = "Ne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label neo;
        private System.Windows.Forms.Label neon;
        private System.Windows.Forms.Label info;
    }
}