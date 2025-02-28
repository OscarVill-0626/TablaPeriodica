namespace TablaPeriodica
{
    partial class Cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cs));
            this.Txt_nomb = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.AutoSize = true;
            this.Txt_nomb.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nomb.Location = new System.Drawing.Point(155, 121);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(63, 23);
            this.Txt_nomb.TabIndex = 0;
            this.Txt_nomb.Text = "Cesio";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(276, -1);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(32, 23);
            this.Txt_numAt.TabIndex = 1;
            this.Txt_numAt.Text = "55";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.Location = new System.Drawing.Point(-3, 144);
            this.Txt_edoOxi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(340, 112);
            this.Txt_edoOxi.TabIndex = 3;
            this.Txt_edoOxi.Text = resources.GetString("Txt_edoOxi.Text");
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(104, -1);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(162, 116);
            this.Txt_smbQui.TabIndex = 4;
            this.Txt_smbQui.Text = "Cs";
            // 
            // Cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(343, 269);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_nomb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cs";
            this.Text = "Cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nomb;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_edoOxi;
        private System.Windows.Forms.Label Txt_smbQui;
    }
}