namespace TablaPeriodica
{
    partial class Mn
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
            this.Txt_nomb = new System.Windows.Forms.Label();
            this.Txt_numAto = new System.Windows.Forms.Label();
            this.Txt_sbmQui = new System.Windows.Forms.Label();
            this.Txt_numOxi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_numOx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.AutoSize = true;
            this.Txt_nomb.Location = new System.Drawing.Point(108, 228);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(125, 25);
            this.Txt_nomb.TabIndex = 0;
            this.Txt_nomb.Text = "Manganeso";
            // 
            // Txt_numAto
            // 
            this.Txt_numAto.AutoSize = true;
            this.Txt_numAto.Location = new System.Drawing.Point(13, 47);
            this.Txt_numAto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAto.Name = "Txt_numAto";
            this.Txt_numAto.Size = new System.Drawing.Size(36, 25);
            this.Txt_numAto.TabIndex = 1;
            this.Txt_numAto.Text = "25";
            // 
            // Txt_sbmQui
            // 
            this.Txt_sbmQui.AutoSize = true;
            this.Txt_sbmQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sbmQui.Location = new System.Drawing.Point(74, 93);
            this.Txt_sbmQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_sbmQui.Name = "Txt_sbmQui";
            this.Txt_sbmQui.Size = new System.Drawing.Size(226, 135);
            this.Txt_sbmQui.TabIndex = 2;
            this.Txt_sbmQui.Text = "Mg";
            // 
            // Txt_numOxi
            // 
            this.Txt_numOxi.AutoSize = true;
            this.Txt_numOxi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_numOxi.Location = new System.Drawing.Point(169, 47);
            this.Txt_numOxi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numOxi.Name = "Txt_numOxi";
            this.Txt_numOxi.Size = new System.Drawing.Size(98, 25);
            this.Txt_numOxi.TabIndex = 3;
            this.Txt_numOxi.Text = "+1      +3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "+2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Txt_numOx
            // 
            this.Txt_numOx.AutoSize = true;
            this.Txt_numOx.Location = new System.Drawing.Point(262, 47);
            this.Txt_numOx.Name = "Txt_numOx";
            this.Txt_numOx.Size = new System.Drawing.Size(122, 25);
            this.Txt_numOx.TabIndex = 5;
            this.Txt_numOx.Text = "+4          +7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(292, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "+5+6";
            // 
            // Mn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(390, 316);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_numOx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_numOxi);
            this.Controls.Add(this.Txt_sbmQui);
            this.Controls.Add(this.Txt_numAto);
            this.Controls.Add(this.Txt_nomb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mn";
            this.Text = "Mn";
            this.Load += new System.EventHandler(this.Mn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nomb;
        private System.Windows.Forms.Label Txt_numAto;
        private System.Windows.Forms.Label Txt_sbmQui;
        private System.Windows.Forms.Label Txt_numOxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Txt_numOx;
        private System.Windows.Forms.Label label7;
    }
}