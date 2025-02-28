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
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.AutoSize = true;
            this.Txt_Nombre.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Nombre.Location = new System.Drawing.Point(88, 115);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(76, 23);
            this.Txt_Nombre.TabIndex = 0;
            this.Txt_Nombre.Text = "Berilio";
            this.Txt_Nombre.Click += new System.EventHandler(this.Txt_Nombre_Click);
            // 
            // Txt_SmbQui
            // 
            this.Txt_SmbQui.AutoSize = true;
            this.Txt_SmbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SmbQui.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_SmbQui.Location = new System.Drawing.Point(52, -1);
            this.Txt_SmbQui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_SmbQui.Name = "Txt_SmbQui";
            this.Txt_SmbQui.Size = new System.Drawing.Size(168, 116);
            this.Txt_SmbQui.TabIndex = 1;
            this.Txt_SmbQui.Text = "Be";
            // 
            // Txt_NumA
            // 
            this.Txt_NumA.AutoSize = true;
            this.Txt_NumA.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_NumA.Location = new System.Drawing.Point(216, -1);
            this.Txt_NumA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_NumA.Name = "Txt_NumA";
            this.Txt_NumA.Size = new System.Drawing.Size(22, 23);
            this.Txt_NumA.TabIndex = 2;
            this.Txt_NumA.Text = "4";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_edoOxi.Location = new System.Drawing.Point(237, 24);
            this.Txt_edoOxi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(0, 17);
            this.Txt_edoOxi.TabIndex = 3;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info.Location = new System.Drawing.Point(0, 138);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            this.info.Click += new System.EventHandler(this.Txt_Nombre_Click);
            // 
            // Be
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(339, 260);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_NumA);
            this.Controls.Add(this.Txt_SmbQui);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Txt_Nombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label info;
    }
}