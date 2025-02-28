namespace TablaPeriodica
{
    partial class Ra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ra));
            this.Txt_nomb = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.AutoSize = true;
            this.Txt_nomb.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nomb.Location = new System.Drawing.Point(101, 116);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(65, 23);
            this.Txt_nomb.TabIndex = 0;
            this.Txt_nomb.Text = "Radio";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(228, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(34, 23);
            this.Txt_numAt.TabIndex = 1;
            this.Txt_numAt.Text = "88";
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(55, 0);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(167, 116);
            this.Txt_smbQui.TabIndex = 2;
            this.Txt_smbQui.Text = "Ra";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(0, 141);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(338, 260);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Txt_nomb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ra";
            this.Text = "Ra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nomb;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label info;
    }
}