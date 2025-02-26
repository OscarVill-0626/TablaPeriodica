namespace TablaPeriodica
{
    partial class Cl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cl));
            this.l17 = new System.Windows.Forms.Label();
            this.clo = new System.Windows.Forms.Label();
            this.cloro = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l17
            // 
            this.l17.AutoSize = true;
            this.l17.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l17.Location = new System.Drawing.Point(237, 13);
            this.l17.Name = "l17";
            this.l17.Size = new System.Drawing.Size(31, 23);
            this.l17.TabIndex = 0;
            this.l17.Text = "17";
            // 
            // clo
            // 
            this.clo.AutoSize = true;
            this.clo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clo.Location = new System.Drawing.Point(100, 34);
            this.clo.Name = "clo";
            this.clo.Size = new System.Drawing.Size(147, 116);
            this.clo.TabIndex = 0;
            this.clo.Text = "Cl";
            // 
            // cloro
            // 
            this.cloro.AutoSize = true;
            this.cloro.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloro.Location = new System.Drawing.Point(147, 150);
            this.cloro.Name = "cloro";
            this.cloro.Size = new System.Drawing.Size(64, 23);
            this.cloro.TabIndex = 0;
            this.cloro.Text = "Cloro";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-2, 192);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Cl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(321, 315);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cloro);
            this.Controls.Add(this.clo);
            this.Controls.Add(this.l17);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cl";
            this.Text = "Cl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l17;
        private System.Windows.Forms.Label clo;
        private System.Windows.Forms.Label cloro;
        private System.Windows.Forms.Label info;
    }
}