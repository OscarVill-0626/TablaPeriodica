namespace TablaPeriodica
{
    partial class H
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
            this.Txt_Hidrogeno = new System.Windows.Forms.Label();
            this.Txt_SimQuim = new System.Windows.Forms.Label();
            this.txt_NumAto = new System.Windows.Forms.Label();
            this.Txt_estOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Hidrogeno
            // 
            this.Txt_Hidrogeno.AutoSize = true;
            this.Txt_Hidrogeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Hidrogeno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_Hidrogeno.Location = new System.Drawing.Point(137, 215);
            this.Txt_Hidrogeno.Name = "Txt_Hidrogeno";
            this.Txt_Hidrogeno.Size = new System.Drawing.Size(111, 25);
            this.Txt_Hidrogeno.TabIndex = 0;
            this.Txt_Hidrogeno.Text = "Hidrógeno";
            // 
            // Txt_SimQuim
            // 
            this.Txt_SimQuim.AutoSize = true;
            this.Txt_SimQuim.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SimQuim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_SimQuim.Location = new System.Drawing.Point(119, 80);
            this.Txt_SimQuim.Name = "Txt_SimQuim";
            this.Txt_SimQuim.Size = new System.Drawing.Size(145, 135);
            this.Txt_SimQuim.TabIndex = 1;
            this.Txt_SimQuim.Text = "H";
            // 
            // txt_NumAto
            // 
            this.txt_NumAto.AutoSize = true;
            this.txt_NumAto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumAto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_NumAto.Location = new System.Drawing.Point(12, 24);
            this.txt_NumAto.Name = "txt_NumAto";
            this.txt_NumAto.Size = new System.Drawing.Size(24, 25);
            this.txt_NumAto.TabIndex = 2;
            this.txt_NumAto.Text = "1";
            // 
            // Txt_estOxi
            // 
            this.Txt_estOxi.AutoSize = true;
            this.Txt_estOxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estOxi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_estOxi.Location = new System.Drawing.Point(293, 28);
            this.Txt_estOxi.Name = "Txt_estOxi";
            this.Txt_estOxi.Size = new System.Drawing.Size(53, 20);
            this.Txt_estOxi.TabIndex = 3;
            this.Txt_estOxi.Text = "-1 +1";
            // 
            // H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(395, 346);
            this.Controls.Add(this.Txt_estOxi);
            this.Controls.Add(this.txt_NumAto);
            this.Controls.Add(this.Txt_SimQuim);
            this.Controls.Add(this.Txt_Hidrogeno);
            this.Name = "H";
            this.Text = "H";
            this.Load += new System.EventHandler(this.H_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_Hidrogeno;
        private System.Windows.Forms.Label Txt_SimQuim;
        private System.Windows.Forms.Label txt_NumAto;
        private System.Windows.Forms.Label Txt_estOxi;
    }
}