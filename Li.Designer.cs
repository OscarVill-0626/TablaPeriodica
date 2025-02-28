namespace TablaPeriodica
{
    partial class Li
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Li));
            this.Txt_nombre = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_edoOx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.AutoSize = true;
            this.Txt_nombre.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(129, 114);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(56, 23);
            this.Txt_nombre.TabIndex = 0;
            this.Txt_nombre.Text = "Litio";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(94, -2);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(131, 116);
            this.Txt_smbQui.TabIndex = 1;
            this.Txt_smbQui.Text = "Li";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(229, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(23, 23);
            this.Txt_numAt.TabIndex = 2;
            this.Txt_numAt.Text = "3";
            // 
            // Txt_edoOx
            // 
            this.Txt_edoOx.AutoSize = true;
            this.Txt_edoOx.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOx.Location = new System.Drawing.Point(2, 137);
            this.Txt_edoOx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_edoOx.Name = "Txt_edoOx";
            this.Txt_edoOx.Size = new System.Drawing.Size(340, 112);
            this.Txt_edoOx.TabIndex = 3;
            this.Txt_edoOx.Text = resources.GetString("Txt_edoOx.Text");
            // 
            // Li
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(341, 256);
            this.Controls.Add(this.Txt_edoOx);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_nombre);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Li";
            this.Text = "Li";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nombre;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_edoOx;
    }
}