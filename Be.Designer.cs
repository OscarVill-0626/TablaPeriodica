namespace TablaPeriodica
{
    partial class Be
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Be));
            this.Txt_Nombre = new System.Windows.Forms.Label();
            this.Txt_SmbQui = new System.Windows.Forms.Label();
            this.Txt_NumA = new System.Windows.Forms.Label();
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.AutoSize = true;
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Nombre.Location = new System.Drawing.Point(158, 214);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(72, 25);
            this.Txt_Nombre.TabIndex = 0;
            this.Txt_Nombre.Text = "Berilio";
            // 
            // Txt_SmbQui
            // 
            this.Txt_SmbQui.AutoSize = true;
            this.Txt_SmbQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SmbQui.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_SmbQui.Location = new System.Drawing.Point(90, 67);
            this.Txt_SmbQui.Name = "Txt_SmbQui";
            this.Txt_SmbQui.Size = new System.Drawing.Size(206, 135);
            this.Txt_SmbQui.TabIndex = 1;
            this.Txt_SmbQui.Text = "Be";
            // 
            // Txt_NumA
            // 
            this.Txt_NumA.AutoSize = true;
            this.Txt_NumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_NumA.Location = new System.Drawing.Point(12, 29);
            this.Txt_NumA.Name = "Txt_NumA";
            this.Txt_NumA.Size = new System.Drawing.Size(24, 25);
            this.Txt_NumA.TabIndex = 2;
            this.Txt_NumA.Text = "4";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_edoOxi.Location = new System.Drawing.Point(316, 29);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(57, 20);
            this.Txt_edoOxi.TabIndex = 3;
            this.Txt_edoOxi.Text = "+1 +2";
            // 
            // Be
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(422, 312);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_NumA);
            this.Controls.Add(this.Txt_SmbQui);
            this.Controls.Add(this.Txt_Nombre);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Be";
            this.Text = "Be";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_Nombre;
        private System.Windows.Forms.Label Txt_SmbQui;
        private System.Windows.Forms.Label Txt_NumA;
        private System.Windows.Forms.Label Txt_edoOxi;
    }
}