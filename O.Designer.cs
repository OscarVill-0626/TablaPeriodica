namespace TablaPeriodica
{
    partial class O
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(O));
            this.l8 = new System.Windows.Forms.Label();
            this.ox = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.oxigeno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(196, 9);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(22, 23);
            this.l8.TabIndex = 0;
            this.l8.Text = "8";
            // 
            // ox
            // 
            this.ox.AutoSize = true;
            this.ox.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ox.Location = new System.Drawing.Point(94, 32);
            this.ox.Name = "ox";
            this.ox.Size = new System.Drawing.Size(124, 116);
            this.ox.TabIndex = 0;
            this.ox.Text = "O";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 161);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(321, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // oxigeno
            // 
            this.oxigeno.AutoSize = true;
            this.oxigeno.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oxigeno.Location = new System.Drawing.Point(101, 138);
            this.oxigeno.Name = "oxigeno";
            this.oxigeno.Size = new System.Drawing.Size(93, 23);
            this.oxigeno.TabIndex = 0;
            this.oxigeno.Text = "Oxígeno";
            // 
            // O
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(323, 285);
            this.Controls.Add(this.oxigeno);
            this.Controls.Add(this.info);
            this.Controls.Add(this.ox);
            this.Controls.Add(this.l8);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "O";
            this.Text = "O";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label ox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label oxigeno;
    }
}