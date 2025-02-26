namespace TablaPeriodica
{
    partial class Cr
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
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_sbmQui = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_numOxi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_nimOx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Location = new System.Drawing.Point(148, 254);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(76, 25);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Cromo";
            // 
            // Txt_sbmQui
            // 
            this.Txt_sbmQui.AutoSize = true;
            this.Txt_sbmQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sbmQui.Location = new System.Drawing.Point(92, 109);
            this.Txt_sbmQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_sbmQui.Name = "Txt_sbmQui";
            this.Txt_sbmQui.Size = new System.Drawing.Size(186, 135);
            this.Txt_sbmQui.TabIndex = 1;
            this.Txt_sbmQui.Text = "Cr";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Location = new System.Drawing.Point(20, 75);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAt.TabIndex = 2;
            this.Txt_numAt.Text = "24";
            // 
            // Txt_numOxi
            // 
            this.Txt_numOxi.AutoSize = true;
            this.Txt_numOxi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_numOxi.Location = new System.Drawing.Point(197, 75);
            this.Txt_numOxi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numOxi.Name = "Txt_numOxi";
            this.Txt_numOxi.Size = new System.Drawing.Size(148, 25);
            this.Txt_numOxi.TabIndex = 3;
            this.Txt_numOxi.Text = "+1+2      +4+5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "+3";
            // 
            // Txt_nimOx
            // 
            this.Txt_nimOx.AutoSize = true;
            this.Txt_nimOx.Location = new System.Drawing.Point(344, 75);
            this.Txt_nimOx.Name = "Txt_nimOx";
            this.Txt_nimOx.Size = new System.Drawing.Size(37, 25);
            this.Txt_nimOx.TabIndex = 5;
            this.Txt_nimOx.Text = "+6";
            // 
            // Cr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(410, 313);
            this.Controls.Add(this.Txt_nimOx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_numOxi);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_sbmQui);
            this.Controls.Add(this.Txt_nom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cr";
            this.Text = "Cr";
            this.Load += new System.EventHandler(this.Cr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_sbmQui;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_numOxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Txt_nimOx;
    }
}