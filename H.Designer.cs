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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H));
            this.Txt_Hidrogeno = new System.Windows.Forms.Label();
            this.Txt_SimQuim = new System.Windows.Forms.Label();
            this.txt_NumAto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Hidrogeno
            // 
            this.Txt_Hidrogeno.AutoSize = true;
            this.Txt_Hidrogeno.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Hidrogeno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_Hidrogeno.Location = new System.Drawing.Point(83, 108);
            this.Txt_Hidrogeno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_Hidrogeno.Name = "Txt_Hidrogeno";
            this.Txt_Hidrogeno.Size = new System.Drawing.Size(112, 23);
            this.Txt_Hidrogeno.TabIndex = 0;
            this.Txt_Hidrogeno.Text = "Hidrógeno";
            // 
            // Txt_SimQuim
            // 
            this.Txt_SimQuim.AutoSize = true;
            this.Txt_SimQuim.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SimQuim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_SimQuim.Location = new System.Drawing.Point(78, -8);
            this.Txt_SimQuim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_SimQuim.Name = "Txt_SimQuim";
            this.Txt_SimQuim.Size = new System.Drawing.Size(117, 116);
            this.Txt_SimQuim.TabIndex = 1;
            this.Txt_SimQuim.Text = "H";
            // 
            // txt_NumAto
            // 
            this.txt_NumAto.AutoSize = true;
            this.txt_NumAto.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumAto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_NumAto.Location = new System.Drawing.Point(199, 9);
            this.txt_NumAto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_NumAto.Name = "txt_NumAto";
            this.txt_NumAto.Size = new System.Drawing.Size(19, 23);
            this.txt_NumAto.TabIndex = 2;
            this.txt_NumAto.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(319, 248);
            this.Controls.Add(this.txt_NumAto);
            this.Controls.Add(this.Txt_SimQuim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Hidrogeno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}